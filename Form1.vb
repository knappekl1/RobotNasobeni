Public Class Form1
    Dim NasobilkaRadio As Boolean
    Dim prikladyRadio As Boolean
    Dim soucin As Integer
    Dim soucinitel1 As Integer
    Dim soucinitel2 As Integer
    Dim cisloNasobilka As Integer
    Dim nasobilkaInput(-1) As String
    Dim errorCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Ahoj, já jsem robot Bela v počítači a vyzkouším tě z násobení")
        gbPriklad.Hide()
        gbNasobilka.Hide()
        tbError.Text = 0

    End Sub
    Private Sub rbNasobilka_CheckedChanged(sender As Object, e As EventArgs) Handles rbNasobilka.CheckedChanged
        NasobilkaRadio = rbNasobilka.Checked
        gbPriklad.Hide()
        gbNasobilka.Show()

        cisloNasobilka = CInt(Math.Ceiling(Rnd() * 9)) + 1
        tbNasobilkaCislo.Text = cisloNasobilka
        tbOutput.Clear()
        tbVysledekNasobilka.Clear()
        tbVysledekNasobilka.Focus()
    End Sub

    Private Sub rbPriklady_CheckedChanged(sender As Object, e As EventArgs) Handles rbPriklady.CheckedChanged
        prikladyRadio = rbPriklady.Checked
        gbNasobilka.Hide()
        gbPriklad.Show()

        soucinitel1 = CInt(Math.Ceiling(Rnd() * 8)) + 1
        soucinitel2 = CInt(Math.Ceiling(Rnd() * 9)) + 1
        soucin = soucinitel1 * soucinitel2
        tbPriklad.Text = soucinitel1 & " x " & soucinitel2 & " ="
        tbOutput.Clear()
        tbVysledekPriklad.Clear()
        tbVysledekPriklad.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnControl.Click
        If prikladyRadio Then
            Dim vysledekInput As Integer
            If Not Integer.TryParse(tbVysledekPriklad.Text, vysledekInput) Then
                MessageBox.Show("Zadej číslo, a nedělej blbosti!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbVysledekPriklad.Clear()
                tbVysledekPriklad.Focus()
                Return
            End If
            If vysledekInput = soucin Then
                tbOutput.Text = "Výborně!" & vbCrLf & vysledekInput & " je správný výsledek!"
            Else
                errorCount += 1
                tbOutput.Text = "Chyba! Tvůj výsledek je " & vysledekInput & "." & vbCrLf & vbCrLf & soucin & " je správný výsledek!"
                tbError.Text = errorCount
            End If
        ElseIf NasobilkaRadio Then
            ReDim nasobilkaInput(9)
            Dim spravnyVysledek(9) As Integer
            Dim nasobilkaConverted(15) As Integer
            Dim errorLog As String = String.Empty
            Dim pocetChyb As Integer = 0
            nasobilkaInput = tbVysledekNasobilka.Text().Split(","c)

            If nasobilkaInput.Length < 10 Then
                MessageBox.Show("Zadala jsi jen " & nasobilkaInput.Length & " čísla! Zadej celou násobilku.", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tbVysledekNasobilka.Clear()
                tbVysledekNasobilka.Focus()
                Return
            End If
            For i As Integer = 0 To 9
                Dim valuePart As String = nasobilkaInput(i).Trim
                Dim intValue As Integer
                If Not Integer.TryParse(valuePart, intValue) Then
                    MessageBox.Show("Zadej čísla oddělená čárkou, a nedělej blbosti!", "Varování", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else
                    spravnyVysledek(i) = (i + 1) * cisloNasobilka
                    nasobilkaConverted(i) = intValue
                    If spravnyVysledek(i) <> nasobilkaConverted(i) Then
                        pocetChyb += 1
                        errorLog += (i + 1).ToString + " x " + cisloNasobilka.ToString + " = " + spravnyVysledek(i).ToString + "  Tvůj výsledek je " + nasobilkaConverted(i).ToString + vbCrLf
                    End If
                End If
            Next i
            If pocetChyb = 0 Then
                tbOutput.Text = "Výborně! Všechny násobky jsou správně!"
            Else
                tbOutput.Text = "Počet Chyb: " + pocetChyb.ToString + vbCrLf + errorLog
                errorCount += pocetChyb
                tbError.Text = errorCount
            End If

        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If prikladyRadio Then
            soucinitel1 = CInt(Math.Ceiling(Rnd() * 8)) + 1
            soucinitel2 = CInt(Math.Ceiling(Rnd() * 9)) + 1
            soucin = soucinitel1 * soucinitel2
            tbPriklad.Text = soucinitel1 & " x " & soucinitel2 & " ="
            tbOutput.Clear()
            tbVysledekPriklad.Clear()
            tbVysledekPriklad.Focus()
        ElseIf NasobilkaRadio Then
            cisloNasobilka = CInt(Math.Ceiling(Rnd() * 8)) + 1
            tbNasobilkaCislo.Text = cisloNasobilka
            tbOutput.Clear()
            tbVysledekNasobilka.Clear()
            tbVysledekNasobilka.Focus()
        End If
    End Sub


End Class
