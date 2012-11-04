Public Class ClassTelefone

    Private Lista_Tipo_Telefone As New List(Of ClassTelefone)

    Private _Numero As String
    Public Property Numero() As String
        Get
            Return _Numero
        End Get
        Set(ByVal value As String)
            _Numero = value
        End Set
    End Property


    Private _Tipo As ClassTipoTelefone
    Public Property Tipo() As ClassTipoTelefone
        Get
            Return _Tipo
        End Get
        Set(ByVal value As ClassTipoTelefone)
            _Tipo = value
        End Set
    End Property
    Private Sub PreencheCombo()
        Dim Tipos_Telefones As New ClassTelefone
        Tipos_Telefones.Tipo = ClassTipoTelefone.CELULAR
        Tipos_Telefones.Tipo = ClassTipoTelefone.RESIDENCIAL
        Tipos_Telefones.Tipo = ClassTipoTelefone.RESIDENCIAL
        Lista_Tipo_Telefone.Add(Tipos_Telefones)
    End Sub

    Private _Tel_Aluno As ClassAluno
    Public Property Tel_Aluno() As ClassAluno
        Get
            Return _Tel_Aluno
        End Get
        Set(ByVal value As ClassAluno)
            _Tel_Aluno = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return "Nº Tel: " & Numero & " - " & "Tipo Tel: " & Tipo.ToString & " Tel Aluno " & Tel_Aluno.ToString

    End Function
End Class
