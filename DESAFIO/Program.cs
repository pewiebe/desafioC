using System;
using System.Data.SqlTypes;
using System.IO;

class Program
{
    static void Main()
    {
        // o arquivo
        string caminhoDoArquivo = @"C:\caminho\para\arquivo.txt";

        string conteudoDoArquivo = File.ReadAllText(caminhoDoArquivo);

        string produto = "";
        int posicao = conteudoDoArquivo.IndexOf("Produto:");
        if (posicao >= 0)
        {
            posicao += "Produto:".Length;
            produto = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string dataAceitacao = "";
        posicao = conteudoDoArquivo.IndexOf("Aceito em:");
        if (posicao >= 0)
        {
            posicao += "Aceito em:".Length;
            dataAceitacao = conteudoDoArquivo.Substring(posicao, 16); 

        string servico = "";
        posicao = conteudoDoArquivo.IndexOf("Serviço:");
        if (posicao >= 0)
        {
            posicao += "Serviço:".Length;
            servico = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string prazo = "";
        posicao = conteudoDoArquivo.IndexOf("Prazo:");
        if (posicao >= 0)
        {
            posicao += "Prazo:".Length;
            prazo = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string local = "";
        posicao = conteudoDoArquivo.IndexOf("Local:");
        if (posicao >= 0)
        {
            posicao += "Local:".Length;
            local = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string complemento = "";
        posicao = conteudoDoArquivo.IndexOf("Complemento:");
        if (posicao >= 0)
        {
            posicao += "Complemento:".Length;
            complemento = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string bairro = "";
        posicao = conteudoDoArquivo.IndexOf("Bairro:");
        if (posicao >= 0)
        {
            posicao += "Bairro:".Length;
            bairro = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string regiao = "";
        posicao = conteudoDoArquivo.IndexOf("Região:");
        if (posicao >= 0)
        {
            posicao += "Região:".Length;
            regiao = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string cidade = "";
        posicao = conteudoDoArquivo.IndexOf("Cidade:");
        if (posicao >= 0)
        {
            posicao += "Cidade:".Length;
            cidade = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string estado = "";
        posicao = conteudoDoArquivo.IndexOf("Estado:");
        if (posicao >= 0)
        {
            posicao += "Estado:".Length;
            estado = conteudoDoArquivo.Substring(posicao).Trim();
        }

        string cep = "";
        posicao = conteudoDoArquivo.IndexOf("CEP:");
        if (posicao >= 0)
        {
            posicao += "CEP:".Length;
            int posicaoFinal = conteudoDoArquivo.IndexOf("\n", posicao);
            cep = conteudoDoArquivo.Substring(posicao, posicaoFinal - posicao).Trim();
        }
    }
}