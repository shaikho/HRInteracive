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
    Public Class VacationTypesController
        Inherits System.Web.Mvc.Controller

        Private db As New DBModels

        ' GET: VacationTypes
        Function Index() As ActionResult
            Return View(db.VacationTypes.ToList())
        End Function

        ' GET: VacationTypes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacationType As VacationType = db.VacationTypes.Find(id)
            If IsNothing(vacationType) Then
                Return HttpNotFound()
            End If
            Return View(vacationType)
        End Function

        ' GET: VacationTypes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: VacationTypes/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="VacatonType,VacationCode")> ByVal vacationType As VacationType) As ActionResult
            If ModelState.IsValid Then
                db.VacationTypes.Add(vacationType)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vacationType)
        End Function

        ' GET: VacationTypes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacationType As VacationType = db.VacationTypes.Find(id)
            If IsNothing(vacationType) Then
                Return HttpNotFound()
            End If
            Return View(vacationType)
        End Function

        ' POST: VacationTypes/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="VacatonType,VacationCode")> ByVal vacationType As VacationType) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vacationType).State = EntityState.Modified
                db.SaveChanges()
                TempData("Success") = "Vacation type edited successfully."
                Return RedirectToAction("Index")
            End If
            Return View(vacationType)
        End Function

        ' GET: VacationTypes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacationType As VacationType = db.VacationTypes.Find(id)
            If IsNothing(vacationType) Then
                Return HttpNotFound()
            End If
            Return View(vacationType)
        End Function

        ' POST: VacationTypes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vacationType As VacationType = db.VacationTypes.Find(id)
            db.VacationTypes.Remove(vacationType)
            db.SaveChanges()
            TempData("Success") = "Vacation type deleted successfully."
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
