Public Class Example3
    Inherits System.Web.UI.Page

    Private _labelFont As String
    Private _monospace As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _labelFont = lblResult.Font.Name
        _monospace = "Courier New"
        If Not IsPostBack Then
            lblResult.Text = ""
            cbClockwise.Checked = False
        End If
        txtValue.Focus()
        lblResult.Text = "Exercise 3 has not been completed yet."
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If btnSubmit.Enabled Then
            btnSubmit.Enabled = False
            lblResult.Text = ""
            Dim sValue = txtValue.Text.Trim()
            Dim nValue As Integer
            If (Not String.IsNullOrEmpty(sValue)) Then
                If (Integer.TryParse(sValue, nValue) And (0 < nValue)) Then
                    lblResult.Font.Name = _monospace
                    lblResult.Text = GetSpiral2(nValue, cbClockwise.Checked)
                Else
                    lblResult.Text = "Please enter an integer value greater than zero (0)."
                    txtValue.Focus()
                End If
            Else
                lblResult.Text = "Please enter a value."
                txtValue.Focus()
            End If
            btnSubmit.Enabled = True
        End If
    End Sub
    ' AI Reference: https://gemini.google.com/share/e77b06c04129
    Private Function GetSpiral(number As Integer, isClockwise As Boolean) As String
        Dim result As String = ""
        ' Calculate the grid size using the ceiling of the square root of "number + 1"
        Dim size As Integer = CInt(Math.Ceiling(Math.Sqrt(number + 1)))
        ' Create a matrix
        Dim matrix(size - 1, size - 1) As Integer
        ' get center row using integer division
        Dim row As Integer = size \ 2
        ' get center column using integer division
        Dim col As Integer = size \ 2
        ' spiral movement variables
        Dim currentNum As Integer = 0
        Dim stepLength As Integer = 1
        Dim dirIndex As Integer = 0
        ' directional vectors for (right, Up, Left, and Down) Counter-Clockwise
        ' Right: (0, 1), Up (-1, 0), Left (0, -1), Down (1, 0)
        Dim rc() As Integer ' row change
        Dim cc() As Integer ' col change
        Dim rowMax As Integer, rowMin As Integer, stepIncrement As Integer
        If (isClockwise) Then
            rowMax = size - 1
            rowMin = 0
            stepIncrement = 1
            rc = New Integer() {0, 1, 0, -1}
            cc = New Integer() {-1, 0, 1, 0}
        Else
            rowMax = 0
            rowMin = size - 1
            stepIncrement = -1
            rc = New Integer() {0, -1, 0, 1}
            cc = New Integer() {1, 0, -1, 0}
        End If
        ' initialize the starting number 0
        matrix(row, col) = currentNum
        currentNum += 1
        ' fill matrix in a loop
        While (currentNum <= number)
            ' A step length is executed twice (right for 1, up for 1, the left for 2, down for 2)
            For turn As Integer = 0 To 1
                If (number < currentNum) Then
                    Exit While ' done
                End If
                ' move stepLenght times in current direction
                For nStep As Integer = 1 To stepLength
                    If (number < currentNum) Then
                        Exit While ' done
                    End If
                    ' update position
                    row += rc(dirIndex)
                    col += cc(dirIndex)
                    ' add row, col to matrix (checking matrix bounds)
                    If ((0 <= col) And (col < size) And (0 <= row) And (row < size)) Then
                        matrix(row, col) = currentNum
                    End If
                    currentNum += 1
                Next
                ' change direction (turn counter-clockwise)
                dirIndex = (dirIndex + 1) Mod 4
            Next
            ' increment step length after every 2 turns
            stepLength += 1
        End While
        ' now print the matrix
        ' determin padding necessary for alignment (based on the largest number)
        Dim maxPadWidth As Integer = number.ToString().Length
        For nRow As Integer = rowMin To rowMax Step stepIncrement
            For nCol As Integer = rowMin To rowMax Step stepIncrement
                ' check if cell was filled
                ' if currentNum was less than size*size, some outer cells might be 0
                Dim x = matrix(nRow, nCol)
                If ((0 <= x) And (x <= number)) Then
                    result += String.Format("{0}", x.ToString().PadLeft(maxPadWidth + 1))
                Else
                    result += " ".PadLeft(maxPadWidth + 1)
                End If
            Next
            result += "<br/>"
        Next
        Return result
    End Function

    Private Function GetSpiral2(maxValue As Integer, isClockwise As Boolean) As String
        Dim size As Integer = CInt(Math.Ceiling(Math.Sqrt(maxValue + 1)))
        Dim matrix(size - 1, size - 1) As Integer
        Dim top As Integer = 0
        Dim bottom As Integer = size - 1
        Dim left As Integer = 0
        Dim right As Integer = size - 1
        Dim current As Integer = CInt(IIf(isClockwise, 0, maxValue))
        While ((top <= bottom) And (left <= right))
            If (isClockwise) Then ' Clockwise: Top => Right => Bottom => Left
                For i As Integer = left To right
                    If (maxValue < current) Then
                        Exit While
                    End If
                    matrix(top, i) = current
                    current += 1
                Next
                top += 1
                For i As Integer = top To bottom
                    If (maxValue < current) Then
                        Exit While
                    End If
                    matrix(i, right) = current
                    current += 1
                Next
                right -= 1
                For i As Integer = right To left Step -1
                    If (maxValue < current) Then
                        Exit While
                    End If
                    matrix(bottom, i) = current
                    current += 1
                Next
                bottom -= 1
                For i As Integer = bottom To top Step -1
                    If (maxValue < current) Then
                        Exit While
                    End If
                    matrix(i, left) = current
                    current += 1
                Next
                left += 1
            Else ' Counter-clockwise: Top => Left => Bottom => Right
                For i As Integer = right To left Step -1
                    If (current < 0) Then
                        Exit While
                    End If
                    matrix(top, i) = current
                    current -= 1
                Next
                top += 1
                For i As Integer = top To bottom
                    If (current < 0) Then
                        Exit While
                    End If
                    matrix(i, left) = current
                    current -= 1
                Next
                left += 1
                For i As Integer = left To right
                    If (current < 0) Then
                        Exit While
                    End If
                    matrix(bottom, i) = current
                    current -= 1
                Next
                bottom -= 1
                For i As Integer = bottom To top Step -1
                    If (current < 0) Then
                        Exit While
                    End If
                    matrix(i, right) = current
                    current -= 1
                Next
                right -= 1
            End If
        End While
        Dim sb As New StringBuilder()
        For row As Integer = 0 To size - 1
            For col As Integer = 0 To size - 1
                sb.Append(matrix(row, col).ToString().PadLeft(4))
            Next
            sb.Append("<br />")
        Next
        Return sb.ToString()
    End Function
End Class