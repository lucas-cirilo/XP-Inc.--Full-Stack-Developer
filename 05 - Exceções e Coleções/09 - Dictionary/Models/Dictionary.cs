namespace _09_Dictionary.Models;

    public class Excecao
    {
        public void Metodo1()
        {
            try
                {
                    Metodo2();
                }
            catch (Exception)
            {
                Console.WriteLine("Exceção tratada");
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
    