Imports System.Data.SqlClient

Public Class Menu

    Private Sub CadastrarAlunoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarAlunoToolStripMenuItem.Click
        CadastroAluno.Show()

    End Sub

    
    Private Sub CADASTRARFUNCIONARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CADASTRARFUNCIONARIOToolStripMenuItem.Click
        CadastroFuncionario.Show()
    End Sub
End Class
