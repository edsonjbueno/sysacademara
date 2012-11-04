Public Class ClassAluno


    Private _Matricula_Aluno As Integer
    Public Property Matricula_Aluno() As Integer
        Get
            Return _Matricula_Aluno
        End Get
        Set(ByVal value As Integer)
            _Matricula_Aluno = value
        End Set
    End Property


    Private _Nome As String
    Public Property Nome() As String
        Get
            Return _Nome
        End Get
        Set(ByVal value As String)
            _Nome = value
        End Set
    End Property

    Private _Data_Nasc As Date
    Public Property Data_Nasc() As Date
        Get
            Return _Data_Nasc
        End Get
        Set(ByVal value As Date)
            _Data_Nasc = value
        End Set
    End Property

    Private _Sexo As String
    Public Property Sexo() As String
        Get
            Return _Sexo
        End Get
        Set(ByVal value As String)
            _Sexo = value
        End Set
    End Property

    Private _Mensalidade As ClassMensalidade
    Public Property Mensalidade() As ClassMensalidade
        Get
            Return _Mensalidade
        End Get
        Set(ByVal value As ClassMensalidade)
            _Mensalidade = value
        End Set
    End Property

    Private _Situacao_Aluno As ClassSituacaoAluno
    Public Property Situacao_Aluno() As ClassSituacaoAluno
        Get
            Return _Situacao_Aluno
        End Get
        Set(ByVal value As ClassSituacaoAluno)
            _Situacao_Aluno = value
        End Set
    End Property

    Private _Telefone As ClassTelefone
    Public Property Telefone() As ClassTelefone
        Get
            Return _Telefone
        End Get
        Set(ByVal value As ClassTelefone)
            _Telefone = value
        End Set
    End Property


    Private _Endereco As ClassEndereco
    Public Property Endereco() As ClassEndereco
        Get
            Return _Endereco
        End Get
        Set(ByVal value As ClassEndereco)
            _Endereco = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Matric.Aluno " & Matricula_Aluno & " Nome " & Nome & " Data.Nasc " & Data_Nasc & " Sexo " & Sexo &
            " Mensalidade " & Mensalidade.ToString & " Situação " & Situacao_Aluno.ToString & " Telefone " & Telefone.ToString &
            " Endereço " & Endereco.ToString
    End Function

End Class
