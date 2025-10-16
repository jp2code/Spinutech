Imports System.Globalization

Public Class WebForm1
    Inherits System.Web.UI.Page

    ' Shared arrays to avoid duplication
    Private Shared ReadOnly unitsMap() As String = {
        "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
        "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
        "seventeen", "eighteen", "nineteen"
    }

    Private Shared ReadOnly tensMap() As String = {
        "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
    }

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblResult.Text = ""
            txtValue.Focus()
        End If
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblResult.Text = ""
        Dim result As String = ""
        Dim value As String = txtValue.Text.Trim()
        If Not String.IsNullOrEmpty(value) Then
            Dim amount As Decimal = 0D
            If Decimal.TryParse(value, amount) Then
                result = ConvertAmountToWords(amount)
            Else
                result = "Value must be able to convert to a decimal."
            End If
        Else
            result = "Value is required."
        End If
        lblResult.Text = result
    End Sub

    Function ConvertAmountToWords(amount As Decimal) As String
        Dim dollars As Integer = CInt(Math.Floor(amount))
        Dim cents As Integer = CInt((amount - dollars) * 100)

        Dim dollarsText As String = NumberToWords(dollars)
        Dim centsText As String = cents.ToString("D2") ' Always two digits

        Return $"{dollarsText} and {centsText}/100 dollars"
    End Function

    Function NumberToWords(number As Long) As String
        If number = 0 Then Return "Zero"

        Dim parts As New List(Of String)

        ' Break into millions, thousands, hundreds
        Dim millions As Long = number \ 1000000 ' The `\` operator is integer division that extracts the millions part of the number, so it discards any remainder
        Dim thousands As Long = (number Mod 1000000) \ 1000 ' (remove the millions part) then get thousands part and discard the remainder
        Dim hundreds As Long = number Mod 1000 ' gets the last 3 digits (the hundreds part)

        If 0 < millions Then
            parts.Add(ConvertThreeDigit(millions) & " million")
        End If

        If 0 < thousands Then
            parts.Add(ConvertThreeDigit(thousands) & " thousand")
        End If

        If 0 < hundreds Then
            parts.Add(ConvertThreeDigit(hundreds))
        End If

        Dim result As String = CapitalizeFirstLetter(String.Join(" ", parts))
        Return result
    End Function

    Function ConvertThreeDigit(number As Long) As String
        Dim result As String = ""
        Dim hundredsDigit As Long = number \ 100
        Dim remainder As Long = number Mod 100
        If 0 < hundredsDigit Then
            result &= unitsMap(CInt(hundredsDigit)) & " hundred"
            If 0 < remainder Then result &= " "
        End If
        Select Case remainder
            Case 0
            ' Do nothing
            Case < 20
                result &= unitsMap(CInt(remainder))
            Case Else
                Dim tensDigit As Long = remainder \ 10
                Dim unitsDigit As Long = remainder Mod 10
                result &= tensMap(CInt(tensDigit))
                If unitsDigit > 0 Then
                    result &= "-" & unitsMap(CInt(unitsDigit)).ToLower()
                End If
        End Select
        Return result.Trim()
    End Function

    Public Function CapitalizeFirstLetter(ByVal inputString As String) As String
        If String.IsNullOrEmpty(inputString) Then
            Return inputString
        Else
            Return inputString.Substring(0, 1).ToUpper() & inputString.Substring(1)
        End If
    End Function

End Class