using Fiap.CopaMundo.Core.Models;
using Fiap.CopaMundo.EntityFramework.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.CopaMundo.EntityFramework.Migrations.SeedData
{
    public class CopaMundoSeedData
    {
        public static void SeedCopaMundo(CopaMundoContext dbContext)
        {
            if (!dbContext.Grupos.Any())
            {
                var grupos = new List<Grupo>
                {
                    new Grupo
                    {
                        Identificador = "A",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Egito",
                                Bandeira = "egito.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Essam El-Hadary" },
                                    new Jogador { Nome = "Mohamed El-Shennawi" },
                                    new Jogador { Nome = "Sherif Ekramy" },
                                    new Jogador { Nome = "Mohamed Awaad" },
                                    new Jogador { Nome = "Ahmed Fathi" },
                                    new Jogador { Nome = "Ahmed Elmohamady" },
                                    new Jogador { Nome = "Omar Gaber" },
                                    new Jogador { Nome = "Mohamed Abdel-Shafi" },
                                    new Jogador { Nome = "Saad Samir" },
                                    new Jogador { Nome = "Ahmed Hegazi" },
                                    new Jogador { Nome = "Ali Gabr" },
                                    new Jogador { Nome = "Ayman Ashraf" },
                                    new Jogador { Nome = "Karim Hafiz" },
                                    new Jogador { Nome = "Amro Tarek" },
                                    new Jogador { Nome = "Mahmoud Hamdy" },
                                    new Jogador { Nome = "Shikabala" },
                                    new Jogador { Nome = "Abdallah El-Said" },
                                    new Jogador { Nome = "Mohamed Elneny" },
                                    new Jogador { Nome = "Tarek Hamed" },
                                    new Jogador { Nome = "Mahmoud Kahraba" },
                                    new Jogador { Nome = "Mahmoud Hassan" },
                                    new Jogador { Nome = "Ramadan Sobhi" },
                                    new Jogador { Nome = "Sam Morsy" },
                                    new Jogador { Nome = "Amr Warda" },
                                    new Jogador { Nome = "Mahmoud Abdel-Aziz" },
                                    new Jogador { Nome = "Mohamed Salah" },
                                    new Jogador { Nome = "Marwan Mohsen" },
                                    new Jogador { Nome = "Ahmed Koka" },
                                    new Jogador { Nome = "Ahmed Gomaa" }
                                }
                            },// EGITO
                            new Selecao
                            {
                                Pais = "Rússia",
                                Bandeira = "russia.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador{ Nome="Akinfeev" },
                                    new Jogador{ Nome="Vladimir Gabulov" },
                                    new Jogador{ Nome="Dzhanaev" },
                                    new Jogador{ Nome="Lunev" },
                                    new Jogador{ Nome="Granat" },
                                    new Jogador{ Nome="Kambolov" },
                                    new Jogador{ Nome="Kudryashov" },
                                    new Jogador{ Nome="Kutepov" },
                                    new Jogador{ Nome="Neustädter" },
                                    new Jogador{ Nome="Rausch" },
                                    new Jogador{ Nome="Semenov" },
                                    new Jogador{ Nome="Smolnikov" },
                                    new Jogador{ Nome="Mário Fernandes" },
                                    new Jogador{ Nome="Gazinsky" },
                                    new Jogador{ Nome="Golovin" },
                                    new Jogador{ Nome="Dzagoev" },
                                    new Jogador{ Nome="Erokhin" },
                                    new Jogador{ Nome="Zhirkov" },
                                    new Jogador{ Nome="Kuziyev" },
                                    new Jogador{ Nome="Zobnin" },
                                    new Jogador{ Nome="Samedov" },
                                    new Jogador{ Nome="Tashaev" },
                                    new Jogador{ Nome="Cheryshev" },
                                    new Jogador{ Nome="Dzyuba" },
                                    new Jogador{ Nome="Miranchuk" },
                                    new Jogador{ Nome="Smolov" },
                                    new Jogador{ Nome="Chalov" }
                                }
                            },// russia
                            new Selecao
                            {
                                Pais = "Arábia Saudita",
                                Bandeira = "arabiasaudita.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador{ Nome = "Assaf Al-Qarny" },
                                    new Jogador{ Nome = "Mohammed Al-Owais" },
                                    new Jogador{ Nome = "Yasser Al-Musailem" },
                                    new Jogador{ Nome = "Abdullah Al-Mayuf" },
                                    new Jogador{ Nome = "Mansoor Al-Harbi" },
                                    new Jogador{ Nome = "Yasser Al-Shahrani" },
                                    new Jogador{ Nome = "Mohammed Al-Breik" },
                                    new Jogador{ Nome = "Saeed Al-Mowalad" },
                                    new Jogador{ Nome = "Motaz Hawsawi" },
                                    new Jogador{ Nome = "Osama Hawsawi" },
                                    new Jogador{ Nome = "Omar Hawsawi" },
                                    new Jogador{ Nome = "Mohammed Jahfali" },
                                    new Jogador{ Nome = "Ali Al-Bulaihi" },
                                    new Jogador{ Nome = "Abdullah Al-Khaibari" },
                                    new Jogador{ Nome = "Abdullah Otayf" },
                                    new Jogador{ Nome = "Taiseer Al-Jassim" },
                                    new Jogador{ Nome = "Hussain Al-Mogahwi" },
                                    new Jogador{ Nome = "Salman Al-Faraj" },
                                    new Jogador{ Nome = "Nawaf Al-Abed" },
                                    new Jogador{ Nome = "Mohammed Kanno" },
                                    new Jogador{ Nome = "Hattan Bahebri" },
                                    new Jogador{ Nome = "Mohammed Al-Kwikbi" },
                                    new Jogador{ Nome = "Salem Al-Dawsari" },
                                    new Jogador{ Nome = "Yahya Al-Shehri" },
                                    new Jogador{ Nome = "Fahad Al-Muwallad" },
                                    new Jogador{ Nome = "Mohammad Al-Sahlawi" },
                                    new Jogador{ Nome = "Muhannad Assiri" },
                                    new Jogador{ Nome = "Abdulmalek Al-Khaibri" }
                                }
                            },// Arabia saudita
                            new Selecao
                            {
                                Pais = "Uruguai",
                                Bandeira = "uruguai.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Fernando Muslera" },
                                    new Jogador { Nome = "Martin Silva" },
                                    new Jogador { Nome = "Martín Campaña" },
                                    new Jogador { Nome = "Diego Godín" },
                                    new Jogador { Nome = "Sebastián Coates" },
                                    new Jogador { Nome = "José Maria Giménez" },
                                    new Jogador { Nome = "Maxi Pereira" },
                                    new Jogador { Nome = "Gastón Silva" },
                                    new Jogador { Nome = "Martín Cáceres" },
                                    new Jogador { Nome = "Guillermo Varela" },
                                    new Jogador { Nome = "Nahitan Nández" },
                                    new Jogador { Nome = "Lucas Torreira" },
                                    new Jogador { Nome = "Matías Vecino" },
                                    new Jogador { Nome = "Federico Valverde" },
                                    new Jogador { Nome = "Rodrigo Bentancur" },
                                    new Jogador { Nome = "Carlos Sánchez" },
                                    new Jogador { Nome = "De Arrascaeta" },
                                    new Jogador { Nome = "Diego Laxalt" },
                                    new Jogador { Nome = "Cristian Rodríguez" },
                                    new Jogador { Nome = "Urreta" },
                                    new Jogador { Nome = "Nicolás Lodeiro" },
                                    new Jogador { Nome = "Gastón Ramírez" },
                                    new Jogador { Nome = "Cristhian Stuani" },
                                    new Jogador { Nome = "Maximiliano Gómez" },
                                    new Jogador { Nome = "Edinson Cavani" },
                                    new Jogador { Nome = "Luis Suárez" }
                                }
                            }// Uruguai
                        }
                    },// GRUPO A
                    new Grupo
                    {
                        Identificador = "B",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Irã",
                                Bandeira = "ira.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Alireza Beiranvand" },
                                    new Jogador { Nome = "Rashid Mazaheri" },
                                    new Jogador { Nome = "Amir Abedzadeh" },
                                    new Jogador { Nome = "Ali Gholizadeh" },
                                    new Jogador { Nome = "Majid Hosseini" },
                                    new Jogador { Nome = "Pejman Montazeri" },
                                    new Jogador { Nome = "Roozbeh Cheshmi" },
                                    new Jogador { Nome = "Milad Mohammadi" },
                                    new Jogador { Nome = "Mohammad Khanzadeh" },
                                    new Jogador { Nome = "Morteza Pouraliganji" },
                                    new Jogador { Nome = "Ramin Rezaeian" },
                                    new Jogador { Nome = "Ehsan Hajsafi" },
                                    new Jogador { Nome = "Karim Ansarifard" },
                                    new Jogador { Nome = "Masoud Shojaei" },
                                    new Jogador { Nome = "Mehdi Torabi" },
                                    new Jogador { Nome = "Omid Ebrahimi" },
                                    new Jogador { Nome = "Saeid Ezatolahi" },
                                    new Jogador { Nome = "Alireza Jahanbakhsh" },
                                    new Jogador { Nome = "Ashkan Dejageh" },
                                    new Jogador { Nome = "Mehdi Taremi" },
                                    new Jogador { Nome = "Reza Ghoochannejhad" },
                                    new Jogador { Nome = "Saman Ghoddos" },
                                    new Jogador { Nome = "Sardar Azmoun" },
                                    new Jogador { Nome = "Vahid Amiri" }
                                }
                            },// IRÃ
                            new Selecao
                            {
                                Pais = "Marrocos",
                                Bandeira = "marrocos.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Munir Mohand Mohamed" },
                                    new Jogador { Nome = "Yassine Bounou" },
                                    new Jogador { Nome = "Ahmed Reda Tagnaouti" },
                                    new Jogador { Nome = "Mehdi Benatia" },
                                    new Jogador { Nome = "Romain Saïss" },
                                    new Jogador { Nome = "Manu Da Costa" },
                                    new Jogador { Nome = "Achraf Hakimi" },
                                    new Jogador { Nome = "Nabil Dirar" },
                                    new Jogador { Nome = "Badr Banoun" },
                                    new Jogador { Nome = "Hamza Mendyl" },
                                    new Jogador { Nome = "Youssef Aït-Bennasser" },
                                    new Jogador { Nome = "Medhi Carcela" },
                                    new Jogador { Nome = "Karim El Ahmadi" },
                                    new Jogador { Nome = "Younes Belhanda" },
                                    new Jogador { Nome = "Hakim Ziyech" },
                                    new Jogador { Nome = "Fayçal Fajr" },
                                    new Jogador { Nome = "Sofyan Amrabat" },
                                    new Jogador { Nome = "Nordin Amrabat" },
                                    new Jogador { Nome = "Mbark Boussaoufa" },
                                    new Jogador { Nome = "Amine Harit" },
                                    new Jogador { Nome = "Aziz Bouhaddouz" },
                                    new Jogador { Nome = "Khalid Boutaïb" },
                                    new Jogador { Nome = "Ayoub El Kaabi" }
                                }
                            },// Marrocos
                            new Selecao
                            {
                                Pais = "Portugal",
                                Bandeira = "portugal.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Anthony Lopes" },
                                    new Jogador { Nome = "Beto" },
                                    new Jogador { Nome = "Rui Patrício" },
                                    new Jogador { Nome = "Bruno Alves" },
                                    new Jogador { Nome = "Cédric Soares" },
                                    new Jogador { Nome = "José Fonte" },
                                    new Jogador { Nome = "Mário Rui" },
                                    new Jogador { Nome = "Pepe" },
                                    new Jogador { Nome = "Raphael Guerreiro" },
                                    new Jogador { Nome = "Ricardo Pereira" },
                                    new Jogador { Nome = "Rúben Dias" },
                                    new Jogador { Nome = "Adrien Silva" },
                                    new Jogador { Nome = "Bruno Fernandes" },
                                    new Jogador { Nome = "João Mário" },
                                    new Jogador { Nome = "João Moutinho" },
                                    new Jogador { Nome = "Manuel Fernandes" },
                                    new Jogador { Nome = "William Carvalho" },
                                    new Jogador { Nome = "André Silva" },
                                    new Jogador { Nome = "Bernardo Silva" },
                                    new Jogador { Nome = "Cristiano Ronaldo" },
                                    new Jogador { Nome = "Gelson Martins" },
                                    new Jogador { Nome = "Gonçalo Guedes" },
                                    new Jogador { Nome = "Ricardo Quaresma" }
                                }
                            },// Portugal
                            new Selecao
                            {
                                Pais = "Espanha",
                                Bandeira = "espanha.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "De Gea" },
                                    new Jogador { Nome = "Reina" },
                                    new Jogador { Nome = "Kepa" },
                                    new Jogador { Nome = "Carvajal" },
                                    new Jogador { Nome = "Nacho" },
                                    new Jogador { Nome = "Sergio Ramos" },
                                    new Jogador { Nome = "Jordi Alba" },
                                    new Jogador { Nome = "Piqué" },
                                    new Jogador { Nome = "Azpilicueta" },
                                    new Jogador { Nome = "Monreal" },
                                    new Jogador { Nome = "Odriozola" },
                                    new Jogador { Nome = "Isco" },
                                    new Jogador { Nome = "Asensio" },
                                    new Jogador { Nome = "Lucas Vázquez" },
                                    new Jogador { Nome = "Busquets" },
                                    new Jogador { Nome = "Iniesta" },
                                    new Jogador { Nome = "Koke" },
                                    new Jogador { Nome = "Saúl" },
                                    new Jogador { Nome = "Thiago Alcântara" },
                                    new Jogador { Nome = "David Silva" },
                                    new Jogador { Nome = "Diego Costa" },
                                    new Jogador { Nome = "Rodrigo" },
                                    new Jogador { Nome = "Iago Aspas" }
                                }
                            }// Espanha
                        }
                    },// GRUPO B
                    new Grupo
                    {
                        Identificador = "C",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Austrália",
                                Bandeira = "australia.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Brad Jones" },
                                    new Jogador { Nome = "Mathew Ryan" },
                                    new Jogador { Nome = "Danny Vukovic" },
                                    new Jogador { Nome = "Aziz Behich" },
                                    new Jogador { Nome = "Milos Degenek" },
                                    new Jogador { Nome = "Matthew Jurman" },
                                    new Jogador { Nome = "Fran Karacic" },
                                    new Jogador { Nome = "James Meredith" },
                                    new Jogador { Nome = "Josh Risdon" },
                                    new Jogador { Nome = "Trent Sainsbury" },
                                    new Jogador { Nome = "Joshua Brillante" },
                                    new Jogador { Nome = "Jackson Irvine" },
                                    new Jogador { Nome = "Mile Jedinak" },
                                    new Jogador { Nome = "Robbie Kruse" },
                                    new Jogador { Nome = "Massimo Luongo" },
                                    new Jogador { Nome = "Mark Milligan" },
                                    new Jogador { Nome = "Aaron Mooy" },
                                    new Jogador { Nome = "Tom Rogic" },
                                    new Jogador { Nome = "James Troisi" },
                                    new Jogador { Nome = "Daniel Arzani" },
                                    new Jogador { Nome = "Tim Cahill" },
                                    new Jogador { Nome = "Tomi Juric" },
                                    new Jogador { Nome = "Mathew Leckie" },
                                    new Jogador { Nome = "Andrew Nabbout" },
                                    new Jogador { Nome = "Dimi Petratos" },
                                    new Jogador { Nome = "Nikita Rukavytsya" }
                                }
                            },// Austrália
                            new Selecao
                            {
                                Pais = "Dinamarca",
                                Bandeira = "dinamarca.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Schmeichel" },
                                    new Jogador { Nome = "Ronnow" },
                                    new Jogador { Nome = "Lössl" },
                                    new Jogador { Nome = "Jesper Hansen" },
                                    new Jogador { Nome = "Kjaer" },
                                    new Jogador { Nome = "Bjelland" },
                                    new Jogador { Nome = "Zanka Jorgensen" },
                                    new Jogador { Nome = "Christensen" },
                                    new Jogador { Nome = "Larsen" },
                                    new Jogador { Nome = "Durmisi" },
                                    new Jogador { Nome = "Vestergaard" },
                                    new Jogador { Nome = "Boilesen" },
                                    new Jogador { Nome = "Ankersen" },
                                    new Jogador { Nome = "Dalsgaard" },
                                    new Jogador { Nome = "Knudsen" },
                                    new Jogador { Nome = "Eriksen" },
                                    new Jogador { Nome = "Delaney" },
                                    new Jogador { Nome = "Kvist" },
                                    new Jogador { Nome = "Schöne" },
                                    new Jogador { Nome = "Lerager" },
                                    new Jogador { Nome = "Jensen" },
                                    new Jogador { Nome = "Hojbjerg" },
                                    new Jogador { Nome = "Krohn-Dehli" },
                                    new Jogador { Nome = "Wass" },
                                    new Jogador { Nome = "Jensen" },
                                    new Jogador { Nome = "Jorgensen" },
                                    new Jogador { Nome = "Cornelius" },
                                    new Jogador { Nome = "Bendtner" },
                                    new Jogador { Nome = "Sisto" },
                                    new Jogador { Nome = "Fischer" },
                                    new Jogador { Nome = "Skov" },
                                    new Jogador { Nome = "Leipzig" },
                                    new Jogador { Nome = "Braithwaite" },
                                    new Jogador { Nome = "Dolberg" },
                                    new Jogador { Nome = "Zohore" }
                                }
                            },// Dinamarca
                            new Selecao
                            {
                                Pais = "França",
                                Bandeira = "franca.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Aréola" },
                                    new Jogador { Nome = "Lloris" },
                                    new Jogador { Nome = "Mandanda" },
                                    new Jogador { Nome = "Lucas Hernández" },
                                    new Jogador { Nome = "Kimpembe" },
                                    new Jogador { Nome = "Mendy" },
                                    new Jogador { Nome = "Pavard" },
                                    new Jogador { Nome = "Rami" },
                                    new Jogador { Nome = "Sidibé" },
                                    new Jogador { Nome = "Umtiti" },
                                    new Jogador { Nome = "Varane" },
                                    new Jogador { Nome = "Kanté" },
                                    new Jogador { Nome = "Matuidi" },
                                    new Jogador { Nome = "N’Zonzi" },
                                    new Jogador { Nome = "Pogba" },
                                    new Jogador { Nome = "Tolisso" },
                                    new Jogador { Nome = "Dembélé" },
                                    new Jogador { Nome = "Fekir" },
                                    new Jogador { Nome = "Giroud" },
                                    new Jogador { Nome = "Griezmann" },
                                    new Jogador { Nome = "Lemar" },
                                    new Jogador { Nome = "Mbappé" },
                                    new Jogador { Nome = "Thauvin" }
                                }
                            },// França
                            new Selecao
                            {
                                Pais = "Peru",
                                Bandeira = "peru.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Carlos Cáceda" },
                                    new Jogador { Nome = "José Carvallo" },
                                    new Jogador { Nome = "Pedro Gallese" },
                                    new Jogador { Nome = "Luis Abram" },
                                    new Jogador { Nome = "Luis Advíncula" },
                                    new Jogador { Nome = "Pedro Aquino" },
                                    new Jogador { Nome = "Miguel Araujo" },
                                    new Jogador { Nome = "Wilder Cartagena" },
                                    new Jogador { Nome = "Aldo Corzo" },
                                    new Jogador { Nome = "Christian Ramos" },
                                    new Jogador { Nome = "Alberto Rodríguez" },
                                    new Jogador { Nome = "Anderson Santamaría" },
                                    new Jogador { Nome = "Miguel Trauco" },
                                    new Jogador { Nome = "Christian Cueva" },
                                    new Jogador { Nome = "Paolo Hurtado" },
                                    new Jogador { Nome = "Nilson Loyola" },
                                    new Jogador { Nome = "Sergio Peña" },
                                    new Jogador { Nome = "Yoshimar Yotún" },
                                    new Jogador { Nome = "Renato Tapia" },
                                    new Jogador { Nome = "Raul Ruidíaz" },
                                    new Jogador { Nome = "Jefferson Farfán" },
                                    new Jogador { Nome = "Edison Flores" },
                                    new Jogador { Nome = "Andy Polo" }
                                }
                            }// Peru
                        }
                    },// GRUPO C
                    new Grupo
                    {
                        Identificador = "D",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Argentina",
                                Bandeira = "argentina.png",
                                Tabela = new Tabela
                                {

                                },
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Romero" },
                                    new Jogador { Nome = "Caballero" },
                                    new Jogador { Nome = "Franco Armani" },
                                    new Jogador { Nome = "Mercado" },
                                    new Jogador { Nome = "Ansaldi" },
                                    new Jogador { Nome = "Otamendi" },
                                    new Jogador { Nome = "Fazio" },
                                    new Jogador { Nome = "Marcos Rojo" },
                                    new Jogador { Nome = "Tagliafico" },
                                    new Jogador { Nome = "Acuña" },
                                    new Jogador { Nome = "Mascherano" },
                                    new Jogador { Nome = "Salvio" },
                                    new Jogador { Nome = "Biglia" },
                                    new Jogador { Nome = "Lo Celso" },
                                    new Jogador { Nome = "Banega" },
                                    new Jogador { Nome = "Lanzini" },
                                    new Jogador { Nome = "Meza" },
                                    new Jogador { Nome = "Di María" },
                                    new Jogador { Nome = "Messi" },
                                    new Jogador { Nome = "Agüero" },
                                    new Jogador { Nome = "Higuaín" },
                                    new Jogador { Nome = "Pavón" },
                                    new Jogador { Nome = "Dybala" }
                                }
                            },// Argentina
                            new Selecao
                            {
                                Pais = "Croácia",
                                Bandeira = "croacia.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Subasic" },
                                    new Jogador { Nome = "Kalinic" },
                                    new Jogador { Nome = "Livakovic" },
                                    new Jogador { Nome = "Vedran Corluka" },
                                    new Jogador { Nome = "Vida" },
                                    new Jogador { Nome = "Strinić" },
                                    new Jogador { Nome = "Lovren" },
                                    new Jogador { Nome = "Vrsaljko" },
                                    new Jogador { Nome = "Pivarić" },
                                    new Jogador { Nome = "Jedvaj" },
                                    new Jogador { Nome = "Mitrovic" },
                                    new Jogador { Nome = "Caleta-Car" },
                                    new Jogador { Nome = "Modric" },
                                    new Jogador { Nome = "Kovacic" },
                                    new Jogador { Nome = "Rakitic" },
                                    new Jogador { Nome = "Badelj" },
                                    new Jogador { Nome = "Brozović" },
                                    new Jogador { Nome = "Filip Bradaric" },
                                    new Jogador { Nome = "Mandzukic" },
                                    new Jogador { Nome = "Perisic" },
                                    new Jogador { Nome = "Kalinic" },
                                    new Jogador { Nome = "Kramaric" },
                                    new Jogador { Nome = "Pjaca" },
                                    new Jogador { Nome = "Rebic" }
                                }
                            },// Croácia
                            new Selecao
                            {
                                Pais = "Islândia",
                                Bandeira = "islandia.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Hannes Pór Halldórsson" },
                                    new Jogador { Nome = "Frederik Schram" },
                                    new Jogador { Nome = "Rúnar Alex Rúnarsson" },
                                    new Jogador { Nome = "Ari Freyr Skúlason" },
                                    new Jogador { Nome = "Hördur B. Magnússon" },
                                    new Jogador { Nome = "Hólmar Örn Eyjólfsson" },
                                    new Jogador { Nome = "Kári Árnason" },
                                    new Jogador { Nome = "Sverrir Ingi Ingason" },
                                    new Jogador { Nome = "Ragnar Sigurdsson" },
                                    new Jogador { Nome = "Samúel K. Fridjónsson" },
                                    new Jogador { Nome = "Birkir Már Saevarsson" },
                                    new Jogador { Nome = "Jóhann Berg Gudmundsson" },
                                    new Jogador { Nome = "Arnór Ingvi Traustason" },
                                    new Jogador { Nome = "Aron Einar Gunnarsson" },
                                    new Jogador { Nome = "Ólafur Ingi Skúlason" },
                                    new Jogador { Nome = "Gylfi Sigurdsson" },
                                    new Jogador { Nome = "Emil Hallfredsson" },
                                    new Jogador { Nome = "Birkir Bjarnason" },
                                    new Jogador { Nome = "Rúrik Gíslason" },
                                    new Jogador { Nome = "Björn B. Sigurdarson" },
                                    new Jogador { Nome = "Albert Gudmundsson" },
                                    new Jogador { Nome = "Alfred Finnbogason" },
                                    new Jogador { Nome = "Jón Dadi Bödvarsson" }
                                }
                            },// Islândia
                            new Selecao
                            {
                                Pais = "Nigéria",
                                Bandeira = "nigeria.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Ikechukwu Ezenwa" },
                                    new Jogador { Nome = "Daniel Akpeyi" },
                                    new Jogador { Nome = "Francis Uzoho" },
                                    new Jogador { Nome = "Dele Ajiboye" },
                                    new Jogador { Nome = "William Ekong" },
                                    new Jogador { Nome = "Leon Balogun" },
                                    new Jogador { Nome = "Olaoluwa Aina" },
                                    new Jogador { Nome = "Kenneth Omeruo" },
                                    new Jogador { Nome = "Bryan Idowu" },
                                    new Jogador { Nome = "Chidozie Awaziem" },
                                    new Jogador { Nome = "Abdullahi Shehu" },
                                    new Jogador { Nome = "Elderson Echiejile" },
                                    new Jogador { Nome = "Tyronne Ebuehi" },
                                    new Jogador { Nome = "Stephen Eze" },
                                    new Jogador { Nome = "John Obi Mikel" },
                                    new Jogador { Nome = "Ogenyi Onazi" },
                                    new Jogador { Nome = "John Ogu" },
                                    new Jogador { Nome = "Wilfred Ndidi" },
                                    new Jogador { Nome = "Uche Agbo" },
                                    new Jogador { Nome = "Oghenekaro Etebo" },
                                    new Jogador { Nome = "Joel Obi" },
                                    new Jogador { Nome = "Mikel Agu" },
                                    new Jogador { Nome = "Odion Ighalo" },
                                    new Jogador { Nome = "Ahmed Musa" },
                                    new Jogador { Nome = "Victor Moses" },
                                    new Jogador { Nome = "Alex Iwobi" },
                                    new Jogador { Nome = "Kelechi Iheanacho" },
                                    new Jogador { Nome = "Moses Simon" },
                                    new Jogador { Nome = "Junior Lokosa" },
                                    new Jogador { Nome = "Simeon Nwankwo" }
                                }
                            }// Nigéria
                        }
                    },// GRUPO D
                    new Grupo
                    {
                        Identificador = "E",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Brasil",
                                Bandeira = "brasil.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Alisson" },
                                    new Jogador { Nome = "Cássio" },
                                    new Jogador { Nome = "Ederson" },
                                    new Jogador { Nome = "Marquinhos" },
                                    new Jogador { Nome = "Thiago Silva" },
                                    new Jogador { Nome = "Geromel" },
                                    new Jogador { Nome = "Miranda" },
                                    new Jogador { Nome = "Fágner" },
                                    new Jogador { Nome = "Danilo" },
                                    new Jogador { Nome = "Marcelo" },
                                    new Jogador { Nome = "Filipe Luis" },
                                    new Jogador { Nome = "Casemiro" },
                                    new Jogador { Nome = "Fernandinho" },
                                    new Jogador { Nome = "Fred" },
                                    new Jogador { Nome = "Paulinho" },
                                    new Jogador { Nome = "Renato Augusto" },
                                    new Jogador { Nome = "Willian" },
                                    new Jogador { Nome = "Philippe Coutinho" },
                                    new Jogador { Nome = "Douglas Costa" },
                                    new Jogador { Nome = "Neymar" },
                                    new Jogador { Nome = "Taison" },
                                    new Jogador { Nome = "Gabriel Jesus" },
                                    new Jogador { Nome = "Roberto Firmino" }
                                }
                            },// Brasil
                            new Selecao
                            {
                                Pais = "Costa Rica",
                                Bandeira = "costarica.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Keylor Navas" },
                                    new Jogador { Nome = "Patrick Pemberton" },
                                    new Jogador { Nome = "Leonel Moreira" },
                                    new Jogador { Nome = "Cristian Gamboa" },
                                    new Jogador { Nome = "Ian Smith" },
                                    new Jogador { Nome = "Ronald Matarita" },
                                    new Jogador { Nome = "Bryan Oviedo" },
                                    new Jogador { Nome = "Oscar Duarte" },
                                    new Jogador { Nome = "Giancarlo González" },
                                    new Jogador { Nome = "Francisco Calvo" },
                                    new Jogador { Nome = "Kendall Watson" },
                                    new Jogador { Nome = "Johnny Acosta" },
                                    new Jogador { Nome = "David Guzmán" },
                                    new Jogador { Nome = "Yeltsin Tejeda" },
                                    new Jogador { Nome = "Celso Borges" },
                                    new Jogador { Nome = "Randall Azofeifa" },
                                    new Jogador { Nome = "Rodney Wallace" },
                                    new Jogador { Nome = "Bryan Ruiz" },
                                    new Jogador { Nome = "Daniel Colindres" },
                                    new Jogador { Nome = "Christian Bolaños" },
                                    new Jogador { Nome = "Johan Venegas" },
                                    new Jogador { Nome = "Joe Campbell" },
                                    new Jogador { Nome = "Marcos Ureña" }
                                }
                            },// Costa Rica
                            new Selecao
                            {
                                Pais = "Sérvia",
                                Bandeira = "servia.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Vladimir Stojkovic" },
                                    new Jogador { Nome = "Marko Dmitrovic" },
                                    new Jogador { Nome = "Predrag Rajkovic" },
                                    new Jogador { Nome = "Aleksandar Jovanovic" },
                                    new Jogador { Nome = "Aleksandar Kolarov" },
                                    new Jogador { Nome = "Antonio Rukavina" },
                                    new Jogador { Nome = "Milan Rodic" },
                                    new Jogador { Nome = "Branislav Ivanovic" },
                                    new Jogador { Nome = "Uros Spajic" },
                                    new Jogador { Nome = "Milos Veljkovic" },
                                    new Jogador { Nome = "Dusko Tosic" },
                                    new Jogador { Nome = "Matija Nastasic" },
                                    new Jogador { Nome = "Nikola Milenkovic" },
                                    new Jogador { Nome = "Nemanja Matic" },
                                    new Jogador { Nome = "Luka Milivojevic" },
                                    new Jogador { Nome = "Marko Grujic" },
                                    new Jogador { Nome = "Nemanja Maksimovic" },
                                    new Jogador { Nome = "Dusan Tadic" },
                                    new Jogador { Nome = "Andrija Zivkovic" },
                                    new Jogador { Nome = "Mijat Gacinovic" },
                                    new Jogador { Nome = "Filip Kostic" },
                                    new Jogador { Nome = "Nemanja Radonjic" },
                                    new Jogador { Nome = "Sergei Milinkovic-Savic" },
                                    new Jogador { Nome = "Adem Ljajic" },
                                    new Jogador { Nome = "Aleksandar Mitrovic" },
                                    new Jogador { Nome = "Aleksandar Prijovic" },
                                    new Jogador { Nome = "Luka Jovic" }
                                }
                            },// Sérvia
                            new Selecao
                            {
                                Pais = "Suíça",
                                Bandeira = "suica.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Roman Bürki" },
                                    new Jogador { Nome = "Gregor Kobel" },
                                    new Jogador { Nome = "Yvon Mvogo" },
                                    new Jogador { Nome = "Yann Sommer" },
                                    new Jogador { Nome = "Manuel Akanji" },
                                    new Jogador { Nome = "Johan Djourou" },
                                    new Jogador { Nome = "Nico Elvedi" },
                                    new Jogador { Nome = "Michael Lang" },
                                    new Jogador { Nome = "Stephan Lichtsteiner" },
                                    new Jogador { Nome = "Jacques-François Moubandje" },
                                    new Jogador { Nome = "Ricardo Rodríguez" },
                                    new Jogador { Nome = "Fabian Schär" },
                                    new Jogador { Nome = "Silvan Widmer" },
                                    new Jogador { Nome = "Valon Behrami" },
                                    new Jogador { Nome = "Blerim Dzemaili" },
                                    new Jogador { Nome = "Edmilson Fernandes" },
                                    new Jogador { Nome = "Gelson Fernandes" },
                                    new Jogador { Nome = "Remo Freuler" },
                                    new Jogador { Nome = "Xherdan Shaqiri" },
                                    new Jogador { Nome = "Granit Xhaka" },
                                    new Jogador { Nome = "Denis Zakaria" },
                                    new Jogador { Nome = "Steven Zuber" },
                                    new Jogador { Nome = "Josip Drmic" },
                                    new Jogador { Nome = "Breel Embolo" },
                                    new Jogador { Nome = "Mario Gavranovic" },
                                    new Jogador { Nome = "Haris Seferovic" }
                                }
                            }// Suíça
                        }
                    },// GRUPO E
                    new Grupo
                    {
                        Identificador = "F",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Alemanha",
                                Bandeira = "alemanha.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Leno" },
                                    new Jogador { Nome = "Neuer" },
                                    new Jogador { Nome = "Ter Stegen" },
                                    new Jogador { Nome = "Trapp" },
                                    new Jogador { Nome = "Boateng" },
                                    new Jogador { Nome = "Hummels" },
                                    new Jogador { Nome = "Kimmich" },
                                    new Jogador { Nome = "Sule" },
                                    new Jogador { Nome = "Ginter" },
                                    new Jogador { Nome = "Hector" },
                                    new Jogador { Nome = "Plattenhardt" },
                                    new Jogador { Nome = "Rüdiger" },
                                    new Jogador { Nome = "Tah" },
                                    new Jogador { Nome = "Brandt" },
                                    new Jogador { Nome = "Draxler" },
                                    new Jogador { Nome = "Mario Gomez" },
                                    new Jogador { Nome = "Goretzka" },
                                    new Jogador { Nome = "Gündogan" },
                                    new Jogador { Nome = "Sané" },
                                    new Jogador { Nome = "Khedira" },
                                    new Jogador { Nome = "Kroos" },
                                    new Jogador { Nome = "Müller" },
                                    new Jogador { Nome = "Rudy" },
                                    new Jogador { Nome = "Özil" },
                                    new Jogador { Nome = "Petersen" },
                                    new Jogador { Nome = "Reus" },
                                    new Jogador { Nome = "Werner" }
                                }
                            },// Alemanha
                            new Selecao
                            {
                                Pais = "Coreia do Sul",
                                Bandeira = "coreiadosul.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "KIm Seung-gyu" },
                                    new Jogador { Nome = "Kim Jin-hyeon" },
                                    new Jogador { Nome = "Cho Hyun-woo" },
                                    new Jogador { Nome = "Kim Young-gwon" },
                                    new Jogador { Nome = "Jang Hyun-soo" },
                                    new Jogador { Nome = "Jeong Seung-hyeon" },
                                    new Jogador { Nome = "Yun Young-sun" },
                                    new Jogador { Nome = "Kwon Kyung-won" },
                                    new Jogador { Nome = "Oh Ban-seok" },
                                    new Jogador { Nome = "Kim Jin-su" },
                                    new Jogador { Nome = "Kim Min-woo" },
                                    new Jogador { Nome = "Park Joo-ho" },
                                    new Jogador { Nome = "Hong Chul" },
                                    new Jogador { Nome = "Go Yo-han" },
                                    new Jogador { Nome = "Lee Yong" },
                                    new Jogador { Nome = "Lee Seung-woo" },
                                    new Jogador { Nome = "Ki Sung-yueng" },
                                    new Jogador { Nome = "Jung Woo-young" },
                                    new Jogador { Nome = "Kwon Chang-hoon" },
                                    new Jogador { Nome = "Ju Se-jong" },
                                    new Jogador { Nome = "Koo Ja-cheol" },
                                    new Jogador { Nome = "Lee Jae-sung" },
                                    new Jogador { Nome = "Moon Seon-min" },
                                    new Jogador { Nome = "Lee Chung-yong" },
                                    new Jogador { Nome = "Kim Shin-wook" },
                                    new Jogador { Nome = "Son Heung-min" },
                                    new Jogador { Nome = "Hwang Hee-chan" },
                                    new Jogador { Nome = "Lee Keun-ho" }
                                }
                            },// Coreia do Sul
                            new Selecao
                            {
                                Pais = "México",
                                Bandeira = "mexico.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Jesús Corona" },
                                    new Jogador { Nome = "Guillermo Ochoa" },
                                    new Jogador { Nome = "Alfredo Talavera" },
                                    new Jogador { Nome = "Héctor Moreno" },
                                    new Jogador { Nome = "Miguel Layún" },
                                    new Jogador { Nome = "Diego Reyes" },
                                    new Jogador { Nome = "Néstor Araujo" },
                                    new Jogador { Nome = "Hugo Ayala" },
                                    new Jogador { Nome = "Carlos Salcedo" },
                                    new Jogador { Nome = "Jesús Gallardo" },
                                    new Jogador { Nome = "Oswaldo Alanís" },
                                    new Jogador { Nome = "Edson Álvarez" },
                                    new Jogador { Nome = "Rafael Marquez" },
                                    new Jogador { Nome = "Jonathan Dos Santos" },
                                    new Jogador { Nome = "Giovani Dos Santos" },
                                    new Jogador { Nome = "Andrés Guardado" },
                                    new Jogador { Nome = "Héctor Herrera" },
                                    new Jogador { Nome = "Javier Aquino" },
                                    new Jogador { Nome = "Jürgen Damm" },
                                    new Jogador { Nome = "Marco Fabián" },
                                    new Jogador { Nome = "Jesús Molina" },
                                    new Jogador { Nome = "Erick Gutiérrez" },
                                    new Jogador { Nome = "Hirving Lozano" },
                                    new Jogador { Nome = "Jesús Manuel" },
                                    new Jogador { Nome = "Raúl Jiménez" },
                                    new Jogador { Nome = "Javier Hernández" },
                                    new Jogador { Nome = "Oribe Peralta" },
                                    new Jogador { Nome = "Carlos Vela" }
                                }
                            },// México
                            new Selecao
                            {
                                Pais = "Suécia",
                                Bandeira = "suecia.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Robin Olsen" },
                                    new Jogador { Nome = "Karl-Johan Johnsson" },
                                    new Jogador { Nome = "Kristoffer Nordfeldt" },
                                    new Jogador { Nome = "Mikael Lustig" },
                                    new Jogador { Nome = "Emil Krafth" },
                                    new Jogador { Nome = "Andreas Granqvist" },
                                    new Jogador { Nome = "Victor Nilsson-Lindelöf" },
                                    new Jogador { Nome = "Pontus Jansson" },
                                    new Jogador { Nome = "Filip Helander" },
                                    new Jogador { Nome = "Ludwig Augustinsson" },
                                    new Jogador { Nome = "Martin Olsson" },
                                    new Jogador { Nome = "Emil Forsberg" },
                                    new Jogador { Nome = "Jimmy Durmaz" },
                                    new Jogador { Nome = "Sebastian Larsson" },
                                    new Jogador { Nome = "Albin Ekdal" },
                                    new Jogador { Nome = "Viktor Claesson" },
                                    new Jogador { Nome = "Gustav Svensson" },
                                    new Jogador { Nome = "Oscar Hiljemark" },
                                    new Jogador { Nome = "Marcus Rohdén" },
                                    new Jogador { Nome = "Marcus Berg" },
                                    new Jogador { Nome = "Ola Toivonen" },
                                    new Jogador { Nome = "John Guidetti" },
                                    new Jogador { Nome = "Isaac Kiese Thelin" }
                                }
                            }// Suécia
                        }
                    },// GRUPO F
                    new Grupo
                    {
                        Identificador = "G",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Bélgica",
                                Bandeira = "belgica.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Koen Casteels" },
                                    new Jogador { Nome = "Thibaut Courtois" },
                                    new Jogador { Nome = "Simon Mignolet" },
                                    new Jogador { Nome = "Matz Sels" },
                                    new Jogador { Nome = "Toby Alderweireld" },
                                    new Jogador { Nome = "Dedryck Boyata" },
                                    new Jogador { Nome = "Laurent Ciman" },
                                    new Jogador { Nome = "Christian Kabasele" },
                                    new Jogador { Nome = "Vincent Kompany" },
                                    new Jogador { Nome = "Jordan Lukaku" },
                                    new Jogador { Nome = "Thomas Meunier" },
                                    new Jogador { Nome = "Thomas Vermaelen" },
                                    new Jogador { Nome = "Jan Vertonghen" },
                                    new Jogador { Nome = "Nacer Chadli" },
                                    new Jogador { Nome = "Kevin De Bruyne" },
                                    new Jogador { Nome = "Mousa Dembele" },
                                    new Jogador { Nome = "Leander Dendoncker" },
                                    new Jogador { Nome = "Marouane Fellaini" },
                                    new Jogador { Nome = "Youri Tielemans" },
                                    new Jogador { Nome = "Axel Witsel" },
                                    new Jogador { Nome = "Michy Batshuayi" },
                                    new Jogador { Nome = "Christian Benteke" },
                                    new Jogador { Nome = "Yannick Carrasco" },
                                    new Jogador { Nome = "Eden Hazard" },
                                    new Jogador { Nome = "Thorgan Hazard" },
                                    new Jogador { Nome = "Adnan Januzaj" },
                                    new Jogador { Nome = "Romelu Lukaku" },
                                    new Jogador { Nome = "Dries Mertens" }
                                }
                            },// Bélgica
                            new Selecao
                            {
                                Pais = "Inglaterra",
                                Bandeira = "inglaterra.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Pickford" },
                                    new Jogador { Nome = "Butland" },
                                    new Jogador { Nome = "Nick Pope" },
                                    new Jogador { Nome = "Alexander-Arnold" },
                                    new Jogador { Nome = "Gary Cahill" },
                                    new Jogador { Nome = "Delph" },
                                    new Jogador { Nome = "Stones" },
                                    new Jogador { Nome = "Walker" },
                                    new Jogador { Nome = "Phil Jones" },
                                    new Jogador { Nome = "Ashley Young" },
                                    new Jogador { Nome = "Danny Rose" },
                                    new Jogador { Nome = "Trippier" },
                                    new Jogador { Nome = "Harry Maguire" },
                                    new Jogador { Nome = "Dier" },
                                    new Jogador { Nome = "Dele Alli" },
                                    new Jogador { Nome = "Jordan Henderson" },
                                    new Jogador { Nome = "Lingard" },
                                    new Jogador { Nome = "Loftus-Cheek" },
                                    new Jogador { Nome = "Raheem Sterling" },
                                    new Jogador { Nome = "Marcus Rashford" },
                                    new Jogador { Nome = "Harry Kane" },
                                    new Jogador { Nome = "Jamie Vardy" },
                                    new Jogador { Nome = "Danny Welbeck" }
                                }
                            },// Inglaterra
                            new Selecao
                            {
                                Pais = "Panamá",
                                Bandeira = "panama.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "José Calderón" },
                                    new Jogador { Nome = "Jaime Penedo" },
                                    new Jogador { Nome = "Alex Rodríguez" },
                                    new Jogador { Nome = "Azmahar Ariano" },
                                    new Jogador { Nome = "Felipe Baloy" },
                                    new Jogador { Nome = "Harold Cummings" },
                                    new Jogador { Nome = "Eric Davis" },
                                    new Jogador { Nome = "Fidel Escobar" },
                                    new Jogador { Nome = "Adolfo Machado" },
                                    new Jogador { Nome = "Michael Murillo" },
                                    new Jogador { Nome = "Luis Ovalle" },
                                    new Jogador { Nome = "Francisco Palacios" },
                                    new Jogador { Nome = "Richard Peralta" },
                                    new Jogador { Nome = "Román Torres" },
                                    new Jogador { Nome = "Ricardo Ávila" },
                                    new Jogador { Nome = "Edgar Barcenas" },
                                    new Jogador { Nome = "Ricardo Buitrago" },
                                    new Jogador { Nome = "Miguel Camargo" },
                                    new Jogador { Nome = "Adalberto Carrasquilla" },
                                    new Jogador { Nome = "Armando Cooper" },
                                    new Jogador { Nome = "Aníbal Godoy" },
                                    new Jogador { Nome = "Gabriel Gómez" },
                                    new Jogador { Nome = "José González" },
                                    new Jogador { Nome = "Cristian Martínez" },
                                    new Jogador { Nome = "Valentín Pimentel" },
                                    new Jogador { Nome = "Alberto Quintero" },
                                    new Jogador { Nome = "José Luis Rodríguez" },
                                    new Jogador { Nome = "Abdiel Arroyo" },
                                    new Jogador { Nome = "Rolando Blackburn" },
                                    new Jogador { Nome = "Ismael Díaz" },
                                    new Jogador { Nome = "José Fajardo" },
                                    new Jogador { Nome = "Roberto Nurse" },
                                    new Jogador { Nome = "Blas Pérez" },
                                    new Jogador { Nome = "Luis Tejada" },
                                    new Jogador { Nome = "Gabriel Torres" }
                                }
                            },// Panamá
                            new Selecao
                            {
                                Pais = "Tunísia",
                                Bandeira = "tunisia.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Aymen Mathlouthi" },
                                    new Jogador { Nome = "Moez Ben Cherifia" },
                                    new Jogador { Nome = "Farouk Ben Mustapha" },
                                    new Jogador { Nome = "Moez Hassen" },
                                    new Jogador { Nome = "Rami Bedoui" },
                                    new Jogador { Nome = "Yohan Benalouane" },
                                    new Jogador { Nome = "Syam Ben Youssef" },
                                    new Jogador { Nome = "Dylan Bronn" },
                                    new Jogador { Nome = "Khalil Chammam" },
                                    new Jogador { Nome = "Oussama Haddadi" },
                                    new Jogador { Nome = "Ali Maaloul" },
                                    new Jogador { Nome = "Yassine Meriah" },
                                    new Jogador { Nome = "Hamdi Nagguez" },
                                    new Jogador { Nome = "Bilel Mohsni" },
                                    new Jogador { Nome = "Mohamed Amine Ben Amor" },
                                    new Jogador { Nome = "Sai-Eddine Khaoui" },
                                    new Jogador { Nome = "Ahmed Khalil" },
                                    new Jogador { Nome = "Ellyes Skhiri" },
                                    new Jogador { Nome = "Ferjani Sassi" },
                                    new Jogador { Nome = "Ghaylene Chaalali" },
                                    new Jogador { Nome = "Mohamed Wael Larbi" },
                                    new Jogador { Nome = "Karim Laribi" },
                                    new Jogador { Nome = "Anice Badri" },
                                    new Jogador { Nome = "Fakhreddine Ben Youssef" },
                                    new Jogador { Nome = "Naim Sliti" },
                                    new Jogador { Nome = "Bassem Srarfi" },
                                    new Jogador { Nome = "Ahmed Akaichi" },
                                    new Jogador { Nome = "Wahbi Khazri" },
                                    new Jogador { Nome = "Saber Khalifa" }
                                }
                            }// Tunísia
                        }
                    },// GRUPO G
                    new Grupo
                    {
                        Identificador = "H",
                        Selecoes = new List<Selecao>
                        {
                            new Selecao
                            {
                                Pais = "Colômbia",
                                Bandeira = "colombia.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Iván Arboleda" },
                                    new Jogador { Nome = "José Fernando Cuadrado" },
                                    new Jogador { Nome = "David Ospina" },
                                    new Jogador { Nome = "Camilo Vargas" },
                                    new Jogador { Nome = "Santiago Arias" },
                                    new Jogador { Nome = "Farid Díaz" },
                                    new Jogador { Nome = "Bernardo Espinosa" },
                                    new Jogador { Nome = "Frank Fabra" },
                                    new Jogador { Nome = "Stefan Medina" },
                                    new Jogador { Nome = "Yerry Mina" },
                                    new Jogador { Nome = "Óscar Murillo" },
                                    new Jogador { Nome = "Dávinson Sánchez" },
                                    new Jogador { Nome = "William Tesillo" },
                                    new Jogador { Nome = "Cristian Zapata" },
                                    new Jogador { Nome = "Wílmar Barrios" },
                                    new Jogador { Nome = "Abel Aguilar" },
                                    new Jogador { Nome = "Edwin Cardona" },
                                    new Jogador { Nome = "Guillermo Cuadrado" },
                                    new Jogador { Nome = "Gustavo Cuéllar" },
                                    new Jogador { Nome = "Jefferson Lerma" },
                                    new Jogador { Nome = "Giovanni Moreno" },
                                    new Jogador { Nome = "Sebastián Pérez" },
                                    new Jogador { Nome = "Juan Fernando Quintero" },
                                    new Jogador { Nome = "James Rodríguez" },
                                    new Jogador { Nome = "Carlos Sánchez" },
                                    new Jogador { Nome = "Mateus Uribe" },
                                    new Jogador { Nome = "Miguel Borja" },
                                    new Jogador { Nome = "Carlos Bacca" },
                                    new Jogador { Nome = "Yimmi Chará" },
                                    new Jogador { Nome = "Falcao García" },
                                    new Jogador { Nome = "Teófilo Gutiérrez" },
                                    new Jogador { Nome = "José Heriberto Izquierdo" },
                                    new Jogador { Nome = "Johan Mojica" },
                                    new Jogador { Nome = "Luis Fernando Muriel" },
                                    new Jogador { Nome = "Duván Zapata" }
                                }
                            },// Colômbia
                            new Selecao
                            {
                                Pais = "Japão",
                                Bandeira = "japao.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Eiji Kawashima" },
                                    new Jogador { Nome = "Masaaki Higashiguchi" },
                                    new Jogador { Nome = "Kosuke Nakamura" },
                                    new Jogador { Nome = "Yuto Nagatomo" },
                                    new Jogador { Nome = "Tomoaki Makino" },
                                    new Jogador { Nome = "Maya Yoshida" },
                                    new Jogador { Nome = "Hiroki Sakai" },
                                    new Jogador { Nome = "Gotoku Sakai" },
                                    new Jogador { Nome = "Gen Shoji" },
                                    new Jogador { Nome = "Wataru Endo" },
                                    new Jogador { Nome = "Naomichi Ueda" },
                                    new Jogador { Nome = "Makoto Hasebe" },
                                    new Jogador { Nome = "Toshihiro Aoyama" },
                                    new Jogador { Nome = "Keisuke Honda" },
                                    new Jogador { Nome = "Takashi Inui" },
                                    new Jogador { Nome = "Shinji Kagawa" },
                                    new Jogador { Nome = "Hotaru Yamaguchi" },
                                    new Jogador { Nome = "Genki Haraguchi" },
                                    new Jogador { Nome = "Takashi Usami" },
                                    new Jogador { Nome = "Gaku Shibasaki" },
                                    new Jogador { Nome = "Ryota Ohshima" },
                                    new Jogador { Nome = "Kento Misao" },
                                    new Jogador { Nome = "Yosuke Ideguchi" },
                                    new Jogador { Nome = "Shinji Okazaki" },
                                    new Jogador { Nome = "Yuya Osako" },
                                    new Jogador { Nome = "Yoshinori Muto" },
                                    new Jogador { Nome = "Takuma Asano" }
                                }
                            },// Japão
                            new Selecao
                            {
                                Pais = "Polônia",
                                Bandeira = "polonia.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Bednarek" },
                                    new Jogador { Nome = "Bereszynski" },
                                    new Jogador { Nome = "Thiago Cionek" },
                                    new Jogador { Nome = "Glik" },
                                    new Jogador { Nome = "Jedrzejczyk" },
                                    new Jogador { Nome = "Kaminski" },
                                    new Jogador { Nome = "Kedziora" },
                                    new Jogador { Nome = "Pazdan" },
                                    new Jogador { Nome = "Piszczek" },
                                    new Jogador { Nome = "Blaszczykowski" },
                                    new Jogador { Nome = "Dawidowicz" },
                                    new Jogador { Nome = "Frankowski" },
                                    new Jogador { Nome = "Goralski" },
                                    new Jogador { Nome = "Grosicki" },
                                    new Jogador { Nome = "Kadzior" },
                                    new Jogador { Nome = "Krychowiak" },
                                    new Jogador { Nome = "Rafal Kurzawa" },
                                    new Jogador { Nome = "Linetty" },
                                    new Jogador { Nome = "Makuszewski" },
                                    new Jogador { Nome = "Maczynski" },
                                    new Jogador { Nome = "Pesko" },
                                    new Jogador { Nome = "Rybus" },
                                    new Jogador { Nome = "Szymanski" },
                                    new Jogador { Nome = "Zielinski" },
                                    new Jogador { Nome = "Zurkowski" },
                                    new Jogador { Nome = "Kownacki" },
                                    new Jogador { Nome = "Lewandowski" },
                                    new Jogador { Nome = "Milik" },
                                    new Jogador { Nome = "Piatek" },
                                    new Jogador { Nome = "Teodorczyk" },
                                    new Jogador { Nome = "Wilczek" },
                                    new Jogador { Nome = "Bialkowski" },
                                    new Jogador { Nome = "Fabianski" },
                                    new Jogador { Nome = "Skorupski" },
                                    new Jogador { Nome = "Szczesny" }
                                }
                            },// Polônia
                            new Selecao
                            {
                                Pais = "Senegal",
                                Bandeira = "senegal.png",
                                Tabela = new Tabela(),
                                Jogadores = new List<Jogador>
                                {
                                    new Jogador { Nome = "Abdoulaye Diallo" },
                                    new Jogador { Nome = "Alfred Gomis" },
                                    new Jogador { Nome = "Khadim N'Diaye" },
                                    new Jogador { Nome = "Kalidou Koulibaly" },
                                    new Jogador { Nome = "Kara Mbodji" },
                                    new Jogador { Nome = "Lamine Gassama" },
                                    new Jogador { Nome = "Moussa Wagué" },
                                    new Jogador { Nome = "Youssouf Sabaly" },
                                    new Jogador { Nome = "Saliou Ciss" },
                                    new Jogador { Nome = "Salif Sané" },
                                    new Jogador { Nome = "Badou Ndiaye" },
                                    new Jogador { Nome = "Cheikh N'Doye" },
                                    new Jogador { Nome = "Cheikhou Kouyaté" },
                                    new Jogador { Nome = "Alfred N'Diaye" },
                                    new Jogador { Nome = "Idrissa Gueye" },
                                    new Jogador { Nome = "M'Baye Niang" },
                                    new Jogador { Nome = "Diafra Sakho" },
                                    new Jogador { Nome = "Moussa Konaté" },
                                    new Jogador { Nome = "Ismaïla Sarr" },
                                    new Jogador { Nome = "Keita Baldé" },
                                    new Jogador { Nome = "Mame Biram Diouf" },
                                    new Jogador { Nome = "Moussa Sow" },
                                    new Jogador { Nome = "Sadio Mané" }
                                }
                            }// Senegal
                        }
                    } // GRUPO H
                };

                dbContext.Grupos.AddRange(grupos);
                dbContext.SaveChanges();
            }
        }
    }
}
