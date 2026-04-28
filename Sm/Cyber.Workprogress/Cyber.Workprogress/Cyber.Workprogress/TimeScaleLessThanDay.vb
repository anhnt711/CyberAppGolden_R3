Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Native

Public Class TimeScaleLessThanDay
    Inherits TimeScaleFixedInterval
    Dim StartHour As Double = 8
    Dim FinishHour As Double = 17
    Dim Finishdate As Date
    Dim Startdate As Date

    Private Shared StartTimeLimitation As TimeSpan = TimeSpan.FromHours(8)
    Private Shared EndTimeLimitation As TimeSpan = TimeSpan.FromHours(18)

    Public Sub New(ByVal scaleValue As TimeSpan, ByVal Start As Integer, ByVal Finish As Integer, ByVal Startdate1 As Date, ByVal Finishdate1 As Date, ByVal Thu_Bay As String, ByVal Chu_Nhat As String)
        MyBase.New(scaleValue)

        DaysToIgnore = New List(Of DayOfWeek)()
        If Thu_Bay.ToString.Trim = "1" Then DaysToIgnore.Add(DayOfWeek.Saturday)
        If Chu_Nhat.ToString.Trim = "1" Then DaysToIgnore.Add(DayOfWeek.Sunday)

        StartHour = Start
        FinishHour = Finish
        Startdate = Startdate1
        Finishdate = Finishdate1
        StartTimeLimitation = TimeSpan.FromHours(StartHour)
        EndTimeLimitation = TimeSpan.FromHours(FinishHour)

    End Sub
    Public ReadOnly Property StartTime() As TimeSpan
        Get
            Return StartTimeLimitation
        End Get
    End Property
    Public ReadOnly Property EndTime() As TimeSpan
        Get
            Return EndTimeLimitation
        End Get
    End Property
    Protected Overrides ReadOnly Property DefaultDisplayFormat() As String
        Get
            Return "HH:mm"
        End Get
    End Property
    Private Property DaysToIgnore() As List(Of DayOfWeek)
    Protected Overrides ReadOnly Property SortingWeight() As TimeSpan
        Get
            Return Value
        End Get
    End Property
    Public Overrides Function Floor(ByVal [date] As Date) As Date
        Try
            If [date] = Date.MinValue OrElse [date] = Date.MaxValue Then
                Return [date]
            End If

            [date] = DateTimeHelper.Floor([date], Value, RoundToHour([date], StartTime))

            Dim time As TimeSpan = [date].TimeOfDay
            If time < StartTime Then
                [date] = RoundToHour([date].AddDays(-1), EndTime)
            ElseIf time > EndTime Then
                [date] = RoundToHour([date], EndTime)
            End If

            Dim newDate As Date = SkipSomeDays([date], -1)
            If newDate <> [date] Then
                [date] = RoundToHour(newDate, EndTime)
            End If

            [date] = DateTimeHelper.Floor([date], Value, RoundToHour([date], StartTime))

            System.Diagnostics.Debug.Assert((StartTime <= [date].TimeOfDay) AndAlso ([date].TimeOfDay <= EndTime))
            Return [date]
        Catch ex As Exception
            Return [date]
        End Try

    End Function
    Public Overrides Function GetNextDate(ByVal [date] As Date) As Date
        Try
            [date] = If(HasNextDate([date]), [date] + Value, [date])

            Dim time As TimeSpan = [date].TimeOfDay
            If time < StartTime Then
                [date] = RoundToHour([date], StartTime)
            ElseIf time > EndTime Then
                [date] = RoundToHour([date].AddDays(1), StartTime)
            End If

            Dim newDate As Date = SkipSomeDays([date], 1)
            If newDate <> [date] Then
                [date] = RoundToHour(newDate, StartTime)
            End If

            System.Diagnostics.Debug.Assert((StartTime <= [date].TimeOfDay) AndAlso ([date].TimeOfDay <= EndTime))
        Catch ex As Exception

        End Try
        Return [date]

    End Function
    Private Function SkipSomeDays(ByVal [date] As Date, ByVal skipDayCount As Integer) As Date
        Dim count As Integer = DaysToIgnore.Count
        For i As Integer = 0 To count - 1
            If Not DaysToIgnore.Contains([date].DayOfWeek) Then
                Return [date]
            End If
            [date] = [date].AddDays(skipDayCount)
        Next i
        Return [date]
    End Function
    Protected Function RoundToHour(ByVal [date] As Date, ByVal timeOfDay As TimeSpan) As Date
        Return [date].Date + timeOfDay
    End Function
    Protected Overrides Function HasNextDate(ByVal [date] As Date) As Boolean
        Return True
    End Function
End Class
