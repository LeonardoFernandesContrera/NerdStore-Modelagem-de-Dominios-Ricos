﻿using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Produto : Entity, IAggregateRoot
    {
        public Guid CategoriaId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public Dimensoes Dimensoes { get; private set; }
        public Categoria Categoria { get; private set; }

        protected Produto() {}

        public Produto(string nome, string descricao, bool ativo, decimal valor, Guid categoriaId, DateTime dataCadastro, string imagem, Dimensoes dimensoes)
        {
            //Failure fast validation, faz o retorno da exception logo cedo 
            //Ex: if(nome = "") throw new Exception("Receba");

            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            CategoriaId = categoriaId;
            Ativo = ativo;
            DataCadastro = dataCadastro;
            Imagem = imagem;
            Dimensoes = dimensoes;

            Validar();
        }

        //Ad rock Setter, seria uma funcao para mudar a propriedade sem faze-lo de forma direta
        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = Categoria.Id;
        }

        public void AlterarDescricao(string descricao)
        {
            Validacoes.ValidarSeVazio(descricao, "O campo Descricao do produto nao pode estar vazio");
            Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            if (!PossuiEstoque(quantidade)) throw new DomainException("Estoque insuficiente");
            QuantidadeEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome do produto nao pode estar vazio");
            Validacoes.ValidarSeVazio(Descricao, "O campo Descricao do produto nao pode estar vazio");
            Validacoes.ValidarSerIgual(CategoriaId, Guid.Empty, "O campo CategoriaId do produto nao pode estar vazio");
            Validacoes.ValidarSerMenorQue(Valor, 1, "O campo Valor do produto nao ser menor igual a 0");
            Validacoes.ValidarSeVazio(Imagem, "O campo Imagem do produto nao pode estar vazio");
        }
    }
}
