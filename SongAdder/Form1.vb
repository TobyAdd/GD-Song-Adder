Imports System.Text
Imports System.IO

Public Class Form1
    Dim appdataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Me.song.Text <> "" And Me.songid.Text <> "" And Me.gdname.Text <> "") Then
            Copy()
        Else
            MessageBox.Show("Error. Some textboxes are not filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub Copy()
        Dim sSource As String = Me.song.Text
        Dim sTarget As String = appdataPath & "\" & Me.gdname.Text & "\" & Me.songid.Text & ".mp3"
        Try
            File.Copy(sSource, sTarget, True)
            MessageBox.Show("Added!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch iox As IOException
            MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SelectMP3.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.song.Text = SelectMP3.FileName
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
