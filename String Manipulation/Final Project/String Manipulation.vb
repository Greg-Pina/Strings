'************************************************
'Greg Pina
'.Net Programming
'String Manipulation
'12/11/17
'*************************************************

Option Strict On
Option Explicit On
Public Class frmFinal

    'Declaring preliminary variables
    Dim strCounty(19) As String
    Dim strState(19) As String
    Dim intHousehold(19) As Integer
    Dim intIndex As Integer
    Dim dblIncome(19) As Double

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' create a random number and display it in lblRandom
        lblRandom.Text = GetRandomString(4)

        'If you forget to enter anything
        If txtCountyState.Text = "" Or txtIncome.Text = "" Then

            MessageBox.Show("All fields are required.")

            Return

        End If

        'Temp string for validating county and state
        Dim strTemporary As String

        strTemporary = txtCountyState.Text

        Dim intCheck As Integer

        intCheck = 0

        For intCounter As Integer = 0 To strTemporary.Length - 1

            If (strTemporary(intCounter) = ",") Then

                intCheck = 1

                Exit For

            End If

        Next

        'validation failed
        If (intCheck = 0) Then

            MessageBox.Show("Please enter as state followed by county, seperated by a comma.", "Invalid Input", MessageBoxButtons.OK)

        Else

            'validation successful, saves data and updates random number generator
            Dim strWords As String() = Split(txtCountyState.Text, ",")

            strCounty(intIndex) = strWords(0)
            strState(intIndex) = strWords(1)
            intHousehold(intIndex) = CInt(Convert.ToDouble(txtIncome.Text))

            MessageBox.Show("Data has been saved sucessfully.", "Application Status")

            intIndex = intIndex + 1

        End If

    End Sub


    'Private function to generate Home Identification Code
    Private Function GetRandomString(ByVal Length As Integer) As String
        'Declare our variables
        Dim strResult As String = ""
        Dim rdmPicker As New System.Random
        Dim allowedChars() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890".ToCharArray

        'Calculations to display Home Identification Code
        For i As Integer = 1 To Length
            strResult += allowedChars(rdmPicker.Next(0, allowedChars.Length))
        Next

        Return strResult

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' create a random number and display it in lblRandom when form loads
        lblRandom.Text = GetRandomString(4)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'closes the application
        Close()
    End Sub

    'Here is where we start the arrays
    Private Sub btnTotalHousehold_Click(sender As Object, e As EventArgs) Handles btnTotalHousehold.Click
        'variables I needed for the arrays
        Dim intTotal As Integer
        Dim intCountyHousehold As Integer
        Dim strMessage As String = ""
        Dim nameOfState As New ArrayList()
        Dim numOfCounties As New ArrayList()

        'Array counter begins
        For intCounter As Integer = 0 To intIndex - 1

            If Not (nameOfState.Contains(strState(intCounter))) Then

                nameOfState.Add(strState(intCounter))

            End If

        Next

        'intCounter continued
        For intCounter As Integer = 0 To intIndex - 1

            If Not (numOfCounties.Contains(strCounty(intCounter))) Then

                numOfCounties.Add(strCounty(intCounter))

            End If

        Next

        Dim intFlag As Integer

        For intCounter As Integer = 0 To numOfCounties.Count - 1

            intCountyHousehold = 0

            For intCounter2 As Integer = 0 To intIndex - 1

                If (numOfCounties(intCounter).ToString() = strCounty(intCounter2)) Then

                    intCountyHousehold = intCountyHousehold + 1

                End If

            Next

            'concantonating the strings
            strMessage += numOfCounties(intCounter).ToString() + "    :   " + intCountyHousehold.ToString() + vbNewLine

            For intCounter3 As Integer = 0 To nameOfState.Count - 1

                intTotal = 0

                intFlag = 0

                For intCounter4 As Integer = 0 To intIndex - 1

                    If (nameOfState(intCounter3).ToString() = strState(intCounter4) And strCounty(intCounter4) = numOfCounties(intCounter).ToString()) Then

                        intTotal = intTotal + 1

                        intFlag = 1

                    End If

                Next

                If intFlag = 1 Then

                    strMessage += "    " + nameOfState(intCounter3).ToString() + "    :   " + intTotal.ToString() + vbNewLine

                End If

            Next

        Next
        'displays total households
        MessageBox.Show(strMessage, "Total Household")

    End Sub

    'This is for the average income
    Private Sub btnAverageHousehold_Click(sender As Object, e As EventArgs) Handles btnAverageHousehold.Click
        'variables I needed for this to work
        Dim dblCountyIncome As Double
        Dim dblStateIncome As Double
        Dim dblTotalState As Double
        Dim dblTotalCounty As Double
        Dim dblAverage As Double = 0.00
        Dim strMessage As String = ""
        Dim nameOfState As New ArrayList()
        Dim numOfCounties As New ArrayList()

        'Same as above, starting a counter
        For intCounter As Integer = 0 To intIndex - 1

            If Not (nameOfState.Contains(strState(intCounter))) Then

                nameOfState.Add(strState(intCounter))

            End If

        Next

        'Array counter continues
        For intCounter As Integer = 0 To intIndex - 1

            If Not (numOfCounties.Contains(strCounty(intCounter))) Then

                numOfCounties.Add(strCounty(intCounter))

            End If

        Next

        'Nested counters
        For intCounter As Integer = 0 To numOfCounties.Count - 1

            dblCountyIncome = 0.00

            dblTotalCounty = 0

            For intCounter2 As Integer = 0 To intIndex - 1

                If (numOfCounties(intCounter).ToString() = strCounty(intCounter2)) Then

                    dblCountyIncome = dblCountyIncome + CDbl(intHousehold(intCounter2))

                    dblTotalCounty = dblTotalCounty + 1

                End If

            Next

            'converting and more concantination
            dblAverage = Convert.ToDouble(dblCountyIncome) / Convert.ToDouble(dblTotalCounty)

            strMessage += numOfCounties(intCounter).ToString() + "    :   $" + dblAverage.ToString() + vbNewLine

            'Counters continue, more nested
            For intCounter3 As Integer = 0 To nameOfState.Count - 1

                dblStateIncome = 0.00

                dblTotalState = 0

                For intCounter4 As Integer = 0 To intIndex - 1

                    If (nameOfState(intCounter3).ToString() = strState(intCounter4) And strCounty(intCounter4) = numOfCounties(intCounter).ToString()) Then

                        dblStateIncome = dblStateIncome + intHousehold(intCounter4)

                        dblTotalState = dblTotalState + 1

                        dblAverage = Convert.ToDouble(dblStateIncome) / Convert.ToDouble(dblTotalState)

                        strMessage += "    " + nameOfState(intCounter3).ToString() + "    :   $" + dblAverage.ToString() + vbNewLine

                    End If

                Next

            Next

        Next
        'Displays the average income
        MessageBox.Show(strMessage, "Average")


    End Sub
End Class
