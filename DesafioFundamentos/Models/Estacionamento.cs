namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        string placa;
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
         public void AddVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para adicionar:"); 
            placa = Console.ReadLine();            
            while(placa=="")
            {                           
                
                Console.WriteLine("O campo da placa não pode ser vazio! Porfavor Digite a placa do veículo para adicionar:");
                placa = Console.ReadLine(); 
                if(placa == "S")
                {
                    break;
                }                                              

            }       
                  
                string carro = placa;
                veiculos.Add(carro.ToUpper());
                placa="";        
                       
        }        
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            
                veiculos.Remove(placa);
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial+(horas * precoPorHora); 

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
             {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
             }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for(int contador = 0;contador<veiculos.Count;contador++)
                {
                     Console.WriteLine($"lista: {veiculos[contador]}");
                    
                }
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
