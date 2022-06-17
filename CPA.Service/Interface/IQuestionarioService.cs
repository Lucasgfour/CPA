﻿using CPA.Data.Model;

namespace CPA.Service.Interface {
    public interface IQuestionarioService {

        Questionario? GetById(int id);

        Questionario? GetByChave(string chave);

        void Add(Questionario questionario, int instituicaoId);

        void Update(Questionario questionario);

    }
}
