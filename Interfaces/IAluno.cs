﻿using APIboletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIboletim.Interfaces
{
    interface IAluno
    {
        Aluno Cadastrar(Aluno a);
        List<Aluno> LerTodos();
        Aluno BuscarPorId(int Id);
        Aluno Alterar(Aluno a);
        Aluno Excluir(Aluno a);

    }
}
