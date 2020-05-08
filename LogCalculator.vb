
Imports System.Windows.Forms

Public Class LogCalculator
    Public Const CustomFormat As String = "H:mm"
    Public Const strTotalHours As String = "Total Hours: "
    Public Const cstrMinTime As String = " 00:01 AM"
    Public Const cstrMaxTime As String = " 23:59 PM"

    Private Sub LogCalculator_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        'Event handler code goes here
        SetCustomTime(LoggedOnTime, 1)
        SetCustomTime(Break1OnTime, 2)
        SetCustomTime(Break1OffTime, 2)
        SetCustomTime(LunchOnTime, 3)
        SetCustomTime(LunchOffTime, 3)
        SetCustomTime(Break2OnTime, 4)
        SetCustomTime(Break2OffTime, 4)
        SetCustomTime(LoggedOffTime, 5)
        Calculate()
    End Sub

    Private Sub SetCustomTime(ByRef timeVariable As DateTimePicker,
                              ByVal timeState As Int16)

        Dim defaultTime As String

        Select Case timeState
            Case 1
                defaultTime = " 8:00 AM"
            Case 2
                defaultTime = " 10:00 AM"
            Case 3
                defaultTime = " 12:00 PM"
            Case 4
                defaultTime = " 2:00 PM"
            Case 5
                defaultTime = " 5:00 PM"
        End Select

        timeVariable.Format = DateTimePickerFormat.Custom
        timeVariable.CustomFormat = CustomFormat
        timeVariable.Value = Convert.ToDateTime(System.DateTime.Today.ToShortDateString() + defaultTime)
        timeVariable.MinDate = Convert.ToDateTime(System.DateTime.Today.ToShortDateString() + cstrMinTime)
        timeVariable.MaxDate = Convert.ToDateTime(System.DateTime.Today.ToShortDateString() + cstrMaxTime)
    End Sub

    Private Sub SetTimesMinMax()
        Break1OnTime.MinDate = LoggedOnTime.Value
        Break1OffTime.MinDate = Break1OnTime.Value
        LunchOnTime.MinDate = If(blnBreak1.Checked, Break1OffTime.Value, LoggedOnTime.Value)
        LunchOffTime.MinDate = LunchOnTime.Value
        Break2OnTime.MinDate = If(blnLunch.Checked, LunchOffTime.Value, If(blnBreak1.Checked, Break1OffTime.Value, LoggedOnTime.Value))
        Break2OffTime.MinDate = Break2OnTime.Value
        LoggedOffTime.MinDate = If(blnBreak2.Checked, Break2OffTime.Value, If(blnLunch.Checked, LunchOffTime.Value, If(blnBreak1.Checked, Break1OffTime.Value, LoggedOnTime.Value)))
        Calculate()
    End Sub

    Private Sub LoggedOnTime_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles LoggedOnTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub Break1OnTime_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles Break1OnTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub Break1OffTime_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles Break1OffTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub LunchTime_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles LunchOnTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub LunchOffTime_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles LunchOffTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub Break2Time_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles Break2OnTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub Break2OffTime_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles Break2OffTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub LoggedOffTime_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles LoggedOffTime.ValueChanged
        SetTimesMinMax()
    End Sub

    Private Sub blnBreak1_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles blnBreak1.CheckedChanged
        SetTimesMinMax()
    End Sub

    Private Sub blnLunch_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles blnLunch.CheckedChanged
        SetTimesMinMax()
    End Sub

    Private Sub blnBreak2_ValueChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles blnBreak2.CheckedChanged
        SetTimesMinMax()
    End Sub

    Private Sub Calculate()
        TotalHours.Text = strTotalHours + GetTime.ToString
    End Sub

    Private Function GetTime() As TimeSpan
        Dim break1Duration, break2Duration, LunchDuration, dayDuration As TimeSpan
        'Calculating Break 1
        If blnBreak1.Checked Then
            break1Duration = (Break1OnTime.Value - Break1OffTime.Value).Duration
        End If
        'Calculating Lunch
        If blnLunch.Checked Then
            LunchDuration = (LunchOnTime.Value - LunchOffTime.Value).Duration
        End If
        'Calculating Break 2
        If blnBreak2.Checked Then
            break2Duration = (Break2OnTime.Value - Break2OffTime.Value).Duration
        End If
        'Calcualate Day Begin and End Duration
        dayDuration = (LoggedOffTime.Value - LoggedOnTime.Value).Duration

        Return dayDuration.Subtract(break1Duration).Subtract(LunchDuration).Subtract(break2Duration)

    End Function

End Class
