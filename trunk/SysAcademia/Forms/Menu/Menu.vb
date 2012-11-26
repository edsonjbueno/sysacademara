Imports System.Data.SqlClient

Public Class Menu

    Private Sub CadastrarAlunoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarAlunoToolStripMenuItem.Click
        CadastroAluno.Show()

    End Sub

    
    Private Sub CADASTRARFUNCIONARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CADASTRARFUNCIONARIOToolStripMenuItem.Click
        CadastroFuncionario.MdiParent = Me
        CadastroFuncionario.Show()
    End Sub

    Private Sub FUNCIONÁRIOToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FUNCIONÁRIOToolStripMenuItem1.Click
        Relatorio_Func.MdiParent = Me
        Relatorio_Func.Show()
    End Sub

    Private Sub CONSULTAFUNCIONÁRIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONSULTAFUNCIONÁRIOToolStripMenuItem.Click
        Consu_Func.MdiParent = Me
        Consu_Func.Show()
    End Sub

    Private Sub FUNCIONÁRIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FUNCIONÁRIOSToolStripMenuItem.Click
        FormGrafFunc.MdiParent = Me
        FormGrafFunc.Show()
    End Sub
End Class
