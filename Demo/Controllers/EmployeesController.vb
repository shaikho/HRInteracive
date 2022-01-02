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
    Public Class EmployeesController
        Inherits System.Web.Mvc.Controller

        Private db As New DBModels

        ' GET: Employees
        Function Index() As ActionResult
            Dim employees = db.Employees.Include(Function(e) e.Department)
            Return View(employees.ToList())
        End Function

        ' GET: Employees/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employee As Employee = db.Employees.Find(id)
            If IsNothing(employee) Then
                Return HttpNotFound()
            End If
            Return View(employee)
        End Function

        ' GET: Employees/Create
        Function Create() As ActionResult
            ViewBag.DepartmentId = New SelectList(db.Departments, "DepartmentId", "Name")
            Return View()
        End Function

        ' POST: Employees/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EmployeeId,Name,Position,Age,Salary,DepartmentId")> ByVal employee As Employee) As ActionResult
            If ModelState.IsValid Then
                db.Employees.Add(employee)
                db.SaveChanges()
                TempData("Success") = "Employee created successfully."
                Return RedirectToAction("Index")
            End If
            ViewBag.DepartmentId = New SelectList(db.Departments, "DepartmentId", "Name", employee.DepartmentId)
            Return View(employee)
        End Function

        ' GET: Employees/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employee As Employee = db.Employees.Find(id)
            If IsNothing(employee) Then
                Return HttpNotFound()
            End If
            ViewBag.DepartmentId = New SelectList(db.Departments, "DepartmentId", "Name", employee.DepartmentId)
            Return View(employee)
        End Function

        ' POST: Employees/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EmployeeId,Name,Position,Age,Salary,DepartmentId")> ByVal employee As Employee) As ActionResult
            If ModelState.IsValid Then
                db.Entry(employee).State = EntityState.Modified
                db.SaveChanges()
                TempData("Success") = "Employee updated successfully."
                Return RedirectToAction("Index")
            End If
            ViewBag.DepartmentId = New SelectList(db.Departments, "DepartmentId", "Name", employee.DepartmentId)
            Return View(employee)
        End Function

        ' GET: Employees/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employee As Employee = db.Employees.Find(id)
            If IsNothing(employee) Then
                Return HttpNotFound()
            End If
            Return View(employee)
        End Function

        ' POST: Employees/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim employee As Employee = db.Employees.Find(id)
            db.Employees.Remove(employee)
            db.SaveChanges()
            TempData("Success") = "Employee deleted successfully."
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
