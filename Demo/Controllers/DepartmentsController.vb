Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Demo

Namespace Controllers
    Public Class DepartmentsController
        Inherits System.Web.Mvc.Controller

        Private db As New DBModels

        ' GET: Departments
        Function Index() As ActionResult
            Return View(db.Departments.ToList())
        End Function

        ' GET: Departments/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim department As Department = db.Departments.Find(id)
            If IsNothing(department) Then
                Return HttpNotFound()
            End If
            Return View(department)
        End Function

        ' GET: Departments/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Departments/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="DepartmentId,Name,Description")> ByVal department As Department) As ActionResult
            If ModelState.IsValid Then
                db.Departments.Add(department)
                db.SaveChanges()
                TempData("Success") = "Department created successfully."
                Return RedirectToAction("Index")
            End If
            Return View(department)
        End Function

        ' GET: Departments/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim department As Department = db.Departments.Find(id)
            If IsNothing(department) Then
                Return HttpNotFound()
            End If
            Return View(department)
        End Function

        ' POST: Departments/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="DepartmentId,Name,Description")> ByVal department As Department) As ActionResult
            If ModelState.IsValid Then
                db.Entry(department).State = EntityState.Modified
                db.SaveChanges()
                TempData("Success") = "Department updated successfully."
                Return RedirectToAction("Index")
            End If
            Return View(department)
        End Function

        ' GET: Departments/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim department As Department = db.Departments.Find(id)
            If IsNothing(department) Then
                Return HttpNotFound()
            End If
            Return View(department)
        End Function

        ' POST: Departments/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim department As Department = db.Departments.Find(id)
            If (department.Employees.Count > 0) Then
                TempData("Fail") = "Can not delete department containing employees."
                Return RedirectToAction("Index")
            End If
            db.Departments.Remove(department)
            db.SaveChanges()
            TempData("Success") = "Department deleted successfully."
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
