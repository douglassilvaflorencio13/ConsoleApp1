// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;
using static Program;

public class Program
{
    public static void Main()
    {
        ICanal whatsappLuciano = new WhatsApp("11950268370");
        ICanal instaLuciano = new Instagram("lucianofelicianojr");
        ICanal facebookLuciano = new Facebook("lucianofeliciano.junior");
        ICanal telegramLuciano = new Telegram("39742358");

        MensagemBasica mensagemTexto = new MensagemBasica();
        mensagemTexto.DataEnvio = DateTime.Now;
        mensagemTexto.Mensagem = "Olá - Mensagem de texto";

        Video mensagemVideo = new Video();
        mensagemVideo.DataEnvio = DateTime.Now;
        mensagemVideo.Mensagem = "Olá - Mensagem de vídeo";
        mensagemVideo.Arquivo = "fim de semana.mp4";
        mensagemVideo.Formato = TiposDeArquivo.MP4;
        mensagemVideo.Duracao = 60;

        Foto mensagemFoto = new Foto();
        mensagemFoto.DataEnvio = DateTime.Now;
        mensagemFoto.Mensagem = "Olá - Mensagem de foto";
        mensagemFoto.Arquivo = "paisagem.jpg";
        mensagemFoto.Formato = TiposDeArquivo.JPG;

        Arquivo mensagemArquivo = new Arquivo();
        mensagemArquivo.DataEnvio = DateTime.Now;
        mensagemArquivo.Mensagem = "Olá - Mensagem de arquivo";
        mensagemArquivo.Arquivo = "documento.pdf";
        mensagemArquivo.Formato = TiposDeArquivo.PDF;

        // Enviando mensagem de texto
        whatsappLuciano.EnviarMensagem(mensagemTexto);
        instaLuciano.EnviarMensagem(mensagemTexto);
        facebookLuciano.EnviarMensagem(mensagemTexto);
        telegramLuciano.EnviarMensagem(mensagemTexto);

        // Enviando mensagem de vídeo
        whatsappLuciano.EnviarMensagem(mensagemVideo);
        instaLuciano.EnviarMensagem(mensagemVideo);
        facebookLuciano.EnviarMensagem(mensagemVideo);
        telegramLuciano.EnviarMensagem(mensagemVideo);

        // Enviando mensagem de foto
        whatsappLuciano.EnviarMensagem(mensagemFoto);
        instaLuciano.EnviarMensagem(mensagemFoto);
        facebookLuciano.EnviarMensagem(mensagemFoto);
        telegramLuciano.EnviarMensagem(mensagemFoto);

        // Enviando mensagem de arquivo
        whatsappLuciano.EnviarMensagem(mensagemArquivo);
        instaLuciano.EnviarMensagem(mensagemArquivo);
        facebookLuciano.EnviarMensagem(mensagemArquivo);
        telegramLuciano.EnviarMensagem(mensagemArquivo);


        ICanal Facebook = new Facebook("luciano.felicianojunior");


    }

    public enum TiposDeArquivo
    {
        MP3,
        MP4,
        JPG,
        PDF
    }

    public interface ICanal
    {
        void EnviarMensagem(MensagemBasica mensagem);

        void EnviarMensagem(MensagemMultimidia mensagem);

        void EnviarMensagem(Video mensagem);

        void EnviarMensagem(Foto mensagem);

        void EnviarMensagem(Arquivo mensagem);
    }

    public abstract class CanaisMensagem : ICanal
    {
        protected abstract string canal { get; }
        private String destinatario { get; set; }
        public void setDestinatario(string destinatario)
        {
            this.destinatario = destinatario;
        }
        public String getDestinatario()
        {
            return this.destinatario;
        }
        public void EnviarMensagem(MensagemBasica mensagem)
        {

            Console.WriteLine("Mensagem básica enviada pelo canal: " + canal);
            Console.WriteLine("Destinatário: " + destinatario);
            Console.WriteLine("Mensagem: " + mensagem.Mensagem);
            Console.WriteLine("Data Envio: " + mensagem.DataEnvio);
        }

        public void EnviarMensagem(MensagemMultimidia mensagem)
        {
            Console.WriteLine("Mensagem multimídia enviada pelo canal: " + canal);
            Console.WriteLine("Destinatário: " + destinatario);
            Console.WriteLine("Mensagem: " + mensagem.Mensagem);
            Console.WriteLine("Data Envio: " + mensagem.DataEnvio);
            Console.WriteLine("Arquivo: " + mensagem.Arquivo);
            Console.WriteLine("Tipo Arquivo: " + mensagem.Formato);
        }

        public void EnviarMensagem(Video mensagem)
        {
            Console.WriteLine("Mensagem vídeo enviada pelo canal: " + canal);
            Console.WriteLine("Destinatário: " + destinatario);
            Console.WriteLine("Mensagem: " + mensagem.Mensagem);
            Console.WriteLine("Data Envio: " + mensagem.DataEnvio);
            Console.WriteLine("Arquivo: " + mensagem.Arquivo);
            Console.WriteLine("Tipo Arquivo: " + mensagem.Formato);
            Console.WriteLine("Duração: " + mensagem.Duracao);
        }

        public void EnviarMensagem(Foto mensagem)
        {
            Console.WriteLine("Mensagem foto enviada pelo canal: " + canal);
            Console.WriteLine("Destinatário: " + destinatario);
            Console.WriteLine("Mensagem: " + mensagem.Mensagem);
            Console.WriteLine("Data Envio: " + mensagem.DataEnvio);
            Console.WriteLine("Arquivo: " + mensagem.Arquivo);
            Console.WriteLine("Tipo Arquivo: " + mensagem.Formato);
        }

        public void EnviarMensagem(Arquivo mensagem)
        {
            Console.WriteLine("Mensagem arquivo enviada pelo canal: " + canal);
            Console.WriteLine("Destinatário: " + destinatario);
            Console.WriteLine("Mensagem: " + mensagem.Mensagem);
            Console.WriteLine("Data Envio: " + mensagem.DataEnvio);
            Console.WriteLine("Arquivo: " + mensagem.Arquivo);
            Console.WriteLine("Tipo Arquivo: " + mensagem.Formato);
        }


    }

    public class WhatsApp : CanaisMensagem, ICanal
    {
        public WhatsApp(String destinatario)
        {
            this.setDestinatario(destinatario);
        }

        protected override string canal { get { return "WhatsApp"; } }


    }

    public class Telegram : CanaisMensagem, ICanal
    {
        public Telegram(String destinatario)
        {
            this.setDestinatario(destinatario);
        }
        protected override string canal { get { return "Telegram"; } }
    }

    public class Instagram : CanaisMensagem, ICanal
    {
        public Instagram(String destinatario)
        {
            this.setDestinatario(destinatario);
        }
        protected override string canal { get { return "Instagram"; } }
    }

    public class Facebook : CanaisMensagem, ICanal
    {
        public Facebook(String destinatario)
        {
            this.setDestinatario(destinatario);
        }
        protected override string canal { get { return "Facebook"; } }
    }

    public class MensagemBasica
    {
        public string Mensagem { get; set; }
        public DateTime DataEnvio { get; set; }
    }

    public class MensagemMultimidia : MensagemBasica
    {
        public string Arquivo { get; set; }
        public TiposDeArquivo Formato { get; set; }
    }

    public class Video : MensagemMultimidia
    {
        public int Duracao { get; set; }
    }

    public class Foto : MensagemMultimidia
    {
    }

    public class Arquivo : MensagemMultimidia
    {
    }
}
