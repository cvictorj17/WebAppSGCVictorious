﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AplicationCore.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {

        TEntity Adicionar(TEntity entity);

        void Atualizar(TEntity entity);

        IEnumerable<TEntity> ObterTodos();

        TEntity ObterPorId(int id);

        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicado);

        void Remover(TEntity entity);

    }
}
