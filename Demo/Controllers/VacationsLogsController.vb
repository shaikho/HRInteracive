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
    Public Class VacationsLogsController
        Inherits System.Web.Mvc.Controller

        Private db As New DBModels

        ' GET: VacationsLogs
        Function Index() As ActionResult
            Dim vacationsLogs = db.VacationsLogs.Include(Function(v) v.Employee).Include(Function(v) v.VacationType)
            Return View(vacationsLogs.ToList())
        End Function

        ' GET: VacationsLogs/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacationsLog As VacationsLog = db.VacationsLogs.Find(id)
            If IsNothing(vacationsLog) Then
                Return HttpNotFound()
            End If
            Return View(vacationsLog)
        End Function

        ' GET: VacationsLogs/Create
        Function Create() As ActionResult
            ViewBag.EmployeeId = New SelectList(db.Employees, "EmployeeId", "Name")
            ViewBag.VacationCode = New SelectList(db.VacationTypes, "VacationCode", "VacatonType")
            Return View()
        End Function

        ' POST: VacationsLogs/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="VacationId,EmployeeId,VacationCode,StartDate,EndDate")> ByVal vacationsLog As VacationsLog) As ActionResult
            If ModelState.IsValid Then
                db.VacationsLogs.Add(vacationsLog)
                db.SaveChanges()
                Return RedirectToAction("Index")
                TempData("Success") = "Vacation created successfully."
            End If
            ViewBag.EmployeeId = New SelectList(db.Employees, "EmployeeId", "Name", vacationsLog.EmployeeId)
            ViewBag.VacationCode = New SelectList(db.VacationTypes, "VacationCode", "VacatonType", vacationsLog.VacationCode)
            Return View(vacationsLog)
        End Function

        ' GET: VacationsLogs/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacationsLog As VacationsLog = db.VacationsLogs.Find(id)
            If IsNothing(vacationsLog) Then
                Return HttpNotFound()
            End If
            ViewBag.EmployeeId = New SelectList(db.Employees, "EmployeeId", "Name", vacationsLog.EmployeeId)
            ViewBag.VacationCode = New SelectList(db.VacationTypes, "VacationCode", "VacatonType", vacationsLog.VacationCode)
            Return View(vacationsLog)
        End Function

        ' POST: VacationsLogs/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="VacationId,EmployeeId,VacationCode,StartDate,EndDate")> ByVal vacationsLog As VacationsLog) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vacationsLog).State = EntityState.Modified
                db.SaveChanges()
                TempData("Success") = "Vacation updated successfully."
                Return RedirectToAction("Index")
            End If
            ViewBag.EmployeeId = New SelectList(db.Employees, "EmployeeId", "Name", vacationsLog.EmployeeId)
            ViewBag.VacationCode = New SelectList(db.VacationTypes, "VacationCode", "VacatonType", vacationsLog.VacationCode)
            Return View(vacationsLog)
        End Function

        ' GET: VacationsLogs/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacationsLog As VacationsLog = db.VacationsLogs.Find(id)
            If IsNothing(vacationsLog) Then
                Return HttpNotFound()
            End If
            Return View(vacationsLog)
        End Function

        ' POST: VacationsLogs/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vacationsLog As VacationsLog = db.VacationsLogs.Find(id)
            db.VacationsLogs.Remove(vacationsLog)
            TempData("Success") = "Vacation deleted successfully."
            db.SaveChanges()
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
