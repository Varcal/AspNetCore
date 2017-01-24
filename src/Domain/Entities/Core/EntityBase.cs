﻿using System;

namespace Domain.Entities.Core
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public DateTime DataCadastro { get; protected set; }
        public bool Ativo { get; protected set; }
    }
}
