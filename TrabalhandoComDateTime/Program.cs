using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime d1 = DateTime.Now; // Devolve instante atual do sistema
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); // Quantidade de ticks que passaram desde o dia 1 de janeiro da era atual, até o dia de hoje

            //Construtores mais utilizados
            DateTime d1 = new DateTime(2020, 08, 28);//Instânciando ano mês e dia
            DateTime d2 = new DateTime(2020, 08, 28, 16, 28, 3);// Instanciando ano, mês, dia, hora, minuto e segundo
            DateTime d3 = new DateTime(2020, 08, 28, 16, 28, 3, 500);// Instanciando ano, mês, dia, hora, minuto, segundo e milisegundo

            //Builders básicos
            DateTime d4 = DateTime.Now;// Gera data e horário atual do sistema
            DateTime d5 = DateTime.Today; //Gera data de hoje, com horário zerado
            DateTime d6 = DateTime.UtcNow; //Horário de agora, só que no GNT que é o horário universal

            

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            */

            //---------------------------------------------------------------------------------------------------------------------

            //DateTime d1 = DateTime.Parse("2000-08-15");
            //DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            //DateTime d3 = DateTime.Parse("15/08/2020");
            //DateTime d4 = DateTime.Parse("15/08/2020 13:05:58");

            //DateTime d5 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture); // Falando para o perse exact que os 4 primeiros digitos é o ano, os outros 2 é o mes e despois os ultimos é o dia
            //DateTime d6 = DateTime.ParseExact("28/08/2020 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture); //Parse exacxt recebe uma mascara de formatação que no caso é o dd/MM/yyyy e o HH:mm:ss

            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);
            //Console.WriteLine(d4);
            //Console.WriteLine(d5);
            //Console.WriteLine(d6);

            // ------------------------------------------------------------
            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            //// PROPRIEDADES \/
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day: " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            //Console.WriteLine("5) Hour: " + d.Hour);
            //Console.WriteLine("6) Kind: " + d.Kind);
            //Console.WriteLine("7) Millisecond: " + d.Millisecond);
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            //Console.WriteLine("13) Year: " + d.Year);

            //-------------------------------------------------------------------

            // Formatações

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //// posso criar uma string Exemplo: string s1 = d.ToLongDateString(); E colocar para imprimir a variável que eu criei => Console.WriteLine(s1); que é a mesma coisa 
            //Console.WriteLine(d.ToLongDateString()); //Mostra de maneiras mais longa mais completa: quarta-feira, 15 de agosto de 2001. // Inclusive pega o formato do PC no caso PT-br // Aqui no caso ele está convertendo para STRING
            //Console.WriteLine(d.ToLongTimeString()); // Resultado: 13:45:58
            //Console.WriteLine(d.ToShortDateString());// Resultado: 15/08/2001
            //Console.WriteLine(d.ToShortTimeString());// Resultado: 13:45
            //Console.WriteLine(d.ToString());// Resultado: 15/08/2001 15:45:58

            ////Com mascara de formatação

            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            //Console.ReadLine();

            // -------------------------------------------------------------------

            // Operações

            //DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            //DateTime d2 = d.AddHours(2);
            //DateTime d3 = d.AddMinutes(3);

            //Console.WriteLine(d);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);


            //// Suponhamos que vamos fazer uma data com 7 dias a mais da atual
            //DateTime d = DateTime.Now; // Pegando data atual

            //DateTime d2 = d.AddDays(7); // adicionando 7 dias nela

            //Console.WriteLine(d); // Instante Atual
            //Console.WriteLine(d2);// Instante 7 dias a mais


            // DIFERENÇA ENTRE 2 DATAS
            //DateTime d1 = new DateTime(2000, 10, 15);

            //DateTime d2 = new DateTime(2000, 10, 18);

            //TimeSpan t = d2.Subtract(d1);

            //Console.WriteLine(t);
            //Console.ReadKey();

        }
    }
}
