Public Class Example6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            lblResult.Text = ""
            txtValue.Focus()
        End If
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblResult.Text = ""
        Dim sValue = txtValue.Text.Trim()
        Dim nValue As Integer
        If (Not String.IsNullOrEmpty(sValue)) Then
            If (Integer.TryParse(sValue, nValue) And (0 < nValue)) Then
                Dim isOrNot As String = IIf(IsPalindromeLinq(nValue), "is", "is not").ToString()
                isOrNot = IIf(IsPalindromeArray(nValue), "is", "is not").ToString()
                lblResult.Text = String.Format("Value [{0}] {1} a palindrome.", nValue, isOrNot)
            Else
                lblResult.Text = "Please enter an integer value greater than zero (0)."
                txtValue.Focus()
            End If
        Else
            lblResult.Text = "Please enter a value."
            txtValue.Focus()
        End If
    End Sub
    ' A palindrome number reads the same forwards and backwards (e.g., 121, 55, 9009).
    Private Function IsPalindromeLinq(ByVal number As Integer) As Boolean
        Dim result As Boolean = False
        lblResult.Text = ""
        ' Input validation: Check if the number is positive. 
        ' Palindromes are typically defined for non-negative integers. 
        ' This implementation assumes a positive integer as requested.
        If (0 < number) Then
            If (number < 10) Then
                lblResult.Text = "Single digits are always palindromes."
                result = True
            Else
                ' Convert to String
                Dim numString As String = number.ToString()
                ' Reverse the string using LINQ
                Dim reversed As String = New String(numString.Reverse().ToArray())
                result = numString.Equals(reversed)
            End If
        Else
            lblResult.Text = "The number must be positive."
        End If
        Return result
    End Function

    Private Function IsPalindromeArray(ByVal number As Integer) As Boolean
        Dim result As Boolean = False
        lblResult.Text = ""
        ' Input validation: Check if the number is positive. 
        ' Palindromes are typically defined for non-negative integers. 
        ' This implementation assumes a positive integer as requested.
        If (0 < number) Then
            If (number < 10) Then
                lblResult.Text = "Single digits are always palindromes."
                result = True
            Else
                ' Convert to String
                Dim numString As String = number.ToString()
                ' Reverse the string using array properties
                Dim list As New List(Of String)
                For n As Integer = numString.Length - 1 To 0 Step -1
                    list.Add(String.Format("{0}", numString(n)))
                Next
                Dim reversed As String = String.Join("", list)
                result = numString.Equals(reversed)
            End If
        Else
            lblResult.Text = "The number must be positive."
        End If
        Return result
    End Function

End Class