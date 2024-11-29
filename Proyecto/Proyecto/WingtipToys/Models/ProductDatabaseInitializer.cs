using System.Collections.Generic; 
using System.Data.Entity;

 
namespace WingtipToys.Models 
{ 
  public class ProductDatabaseInitializer : 
DropCreateDatabaseAlways<ProductContext> 
  { 
    protected override void Seed(ProductContext context) 
    { 
      GetCategories().ForEach(c => context.Categories.Add(c)); 
      GetProducts().ForEach(p => context.Products.Add(p)); 
    } 
 
    private static List<Category> GetCategories() 
    { 
      var categories = new List<Category> { 
                new Category 
                { 
                    CategoryID = 1, 
                    CategoryName = "Carros" 
                }, 
                new Category 
                { 
                    CategoryID = 2, 
                    CategoryName = "Camiones" 
                }, 
                new Category 
                { 
                    CategoryID = 3, 
                    CategoryName = "Aviones" 
                }, 
                new Category 
                { 
                    CategoryID = 4, 
                    CategoryName = "Botes" 
                }, 
                new Category 
                { 
                    CategoryID = 5, 
                    CategoryName = "Naves" 
                },
              
                 new Category {
                     CategoryID = 6,
                     CategoryName = "Todos",
                     Products = GetProducts() // Agrega todos los productos a la categoría "Todos"
                 },
            }; 
 
      return categories; 
    } 
 
    private static List<Product> GetProducts() 
    { 
      var products = new List<Product> { 
                new Product 
                { 
                    ProductID = 1, 
                    ProductName = "Volkswagen Combi T2",
                    Description = "Símbolo por excelencia tanto del movimiento hippie  lml de los fanáticos del surf, representó el anhelo de la libertad de toda una generación.",                      
                    ImagePath="1.png", 
                    UnitPrice = 580.000,
                    CategoryID = 1,
                    Age = 1978
               }, 
                new Product  
                { 
                    ProductID = 2, 
                    ProductName = "Volkswagen Brasilia", 
                    Description = "Concebido para combinar la robustez del Sedán con la comodidad de un auto más moderno, su nombre fue un homenaje a la ciudad más futurista de su era.", 
                    ImagePath="2.png", 
                    UnitPrice = 200.900,
                    CategoryID = 1,
                    Age = 1979
               }, 
                new Product 
                { 
                    ProductID = 3, 
                    ProductName = "Renault Dinalpin", 
                    Description = "Con una producción muy reducida y su fama de deportivo sin concesiones, el Dinalpin todavía se ve moderno hoy en día, gracias al avanzado diseño de su época.", 
                    ImagePath="3.png", 
                    UnitPrice = 890.000, 
                    CategoryID = 1,
                    Age = 1972
                }, 
                new Product 
                { 
                    ProductID = 4, 
                    ProductName = "Ford F-100 Pick-up", 
                    Description = "La quinta generación de la eterna pick-up de la marca del óvalo azul mejoró su diseño y sus prestaciones para seguir siendo la preferida del público", 
                    ImagePath="4.png", 
                    UnitPrice = 450.000, 
                    CategoryID = 1,
                    Age = 1972
                }, 
                new Product 
                { 
                    ProductID = 5, 
                    ProductName = "Ford Maverick", 
                    Description = "Diseño para hacer frente a la creciente demanda de coches europeos y japoneses, Ford creó este compacto, con nombre de rebelde, ideal para jóvenes.", 
                    ImagePath="5.png", 
                    UnitPrice = 205.000, 
                    CategoryID = 1,
                    Age = 1979
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Ford Mustang Convertible",
                    Description = "Sentó las bases de un nuevo concepto automovilístico, el de los \"pony cars\", y fue un destacado protagonista tanto en lso circuitos como en la gran pantalla.",
                    ImagePath="6.png",
                    UnitPrice = 230.000,
                    CategoryID = 1,
                    Age = 1965
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Volkswagen Sedán",
                    Description = "En producción desde 1938 hasta 2003 y vendido en 91 países, el Volkswagen Sedán es una celebridad por mérito propio con millones de seguidores.",
                    ImagePath="7.png",
                    UnitPrice = 150.000,
                    CategoryID = 1,
                    Age = 1968
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Fvam Jeep Cj-7 Renegado",
                    Description = "Descendiente de un linaje histórico que fue protagonista en muchos frentes desde 1941, el Cj-7 Renegado fue el último de su especie fiel a la leyenda.",
                    ImagePath="8.png",
                    UnitPrice = 370.000,
                    CategoryID = 1,
                    Age = 2003
                },
                new Product 
                { 
                    ProductID = 9, 
                    ProductName = "Peterbilt 359 Tractor eléctrico", 
                    Description = "Para los camioneros profesionales, esta joya es sinónimo de rendimiento fiable. Para los viajeros, es una vista común en la carretera. Los Peterbilt® 359 Conventionals llevan años transportando mercancías de una costa a otra a lo largo de muchos millones de kilómetros.\r\n", 
                    ImagePath="9.png", 
                    UnitPrice = 800.000, 
                    CategoryID = 2,
                    Age = 2004
                }, 
                new Product 
                { 
                    ProductID = 10, 
                    ProductName = "Kenworth® W900", 
                    Description = "El impresionante Kenworth W900 simplemente tiene todo lo que es importante para que los conductores de larga distancia hagan su trabajo. El imponente diseño del Kenworth cuenta con un doble umbral encerrado por un panel aerodinámico en el techo que hace que todos se den cuenta de que esta máquina de carretera es insuperable.", 
                    ImagePath="10.png", 
                    UnitPrice = 400.000, 
                    CategoryID = 2,
                    Age = 1978
                }, 
                new Product 
                { 
                    ProductID = 11, 
                    ProductName = "Firetruck P 360", 
                    Description = "El Firetruck P 360 es un vehículo de emergencia robusto y versátil diseñado para responder con eficacia a situaciones críticas. Equipado con tecnología de punta y materiales de alta resistencia, este camión de bomberos está optimizado para maniobrar en terrenos difíciles y proporcionar acceso rápido a zonas de difícil acceso. Su diseño ergonómico y su capacidad para transportar grandes cantidades de agua y equipos especializados lo convierten en una herramienta indispensable para los servicios de rescate y protección contra incendios.", 
                    ImagePath="11.png", 
                    UnitPrice = 980.000, 
                    CategoryID = 2,
                    Age = 1981
                }, 
                new Product 
                { 
                    ProductID = 12, 
                    ProductName = "Torpedo Streamline 4x2", 
                    Description = "El 3 Series Torpedo Streamline 4x2 es un vehículo robusto y aerodinámico con tracción en dos ruedas, diseñado para ofrecer eficiencia y rendimiento en terrenos diversos. Ideal para aquellos que buscan una combinación de estilo, velocidad y confiabilidad en sus desplazamientos diarios.", 
                    ImagePath="12.png", 
                    UnitPrice = 780.000, 
                    CategoryID = 2,
                    Age = 2011
                }, 
                new Product 
                { 
                    ProductID = 13, 
                    ProductName = "G 500 Heavy Tipper", 
                    Description = "Scania CG17L 8x4 con carrocería de volquete minero y XT estampado en el lateral de la cabina.", 
                    ImagePath="13.png", 
                    UnitPrice = 640.000, 
                    CategoryID = 2,
                    Age = 2021
                },
                  new Product
                {
                    ProductID = 14,
                    ProductName = "Svempa Frostfire",
                    Description = "Frostfire, que ha sido diseñado por Scania junto a Svempa, es la creación emblemática más reciente de Sven Erik Bergendahl. Un sensacional modelo inspirado en el Scania V8, con unos tonos azul hielo y naranja fuego, y un diseño que simula el hielo roto. Además cuenta, como no podía ser de otra forma en una creación de Svempa, con un trazo hábil, con elementos estilísticos de la marca y con una cuidado especial por los detalles.",
                    ImagePath="14.png",
                    UnitPrice = 340.000,
                    CategoryID = 2,
                    Age = 1981
                },
                    new Product
                {
                    ProductID = 15,
                    ProductName = "Scania 770 S V8 Frost Edition",
                    Description = "Diseñado por Scania en colaboración con Svempa, el Frost es el último de las construcciónes emblemáticas de Sven Erik Bergendahl. Con un exterior de color azul escarcha, este último modelo de exhibición sobre la base de el Scania 770 S V8, con toques sutiles, elementos de estilo característicos y una gran atención a la detalle que sólo se puede esperar de una construcción de Svempa.",
                    ImagePath="15.png",
                    UnitPrice = 500.150,
                    CategoryID = 2,
                    Age = 2023
                },
                      new Product
                {
                    ProductID = 16,
                    ProductName = "Scania V8 4 Series Torpedo",
                    Description = "El Scania V8 4 Series Torpedo es un camión potente y duradero, equipado con un motor V8 que proporciona un rendimiento excepcional y una capacidad de carga superior. Ideal para el transporte de larga distancia, combina fuerza y eficiencia con un diseño aerodinámico y moderno.",
                    ImagePath="16.png",
                    UnitPrice = 550.000,
                    CategoryID = 2,
                    Age = 2009
                },
                new Product 
                { 
                    ProductID = 17, 
                    ProductName = "Rafale M No 28, Operación Libia 2011", 
                    Description = "Modelo de metal fundido premontado de alta calidad. Partes móviles. Pintado y con marcas detalladas. Edición limitada, entregada con una base: 800 piezas Hoja de calcas incluida.", 
                    ImagePath="17.png", 
                    UnitPrice = 360.900, 
                    CategoryID = 3,
                    Age = 2005
                }, 
                new Product 
                { 
                    ProductID = 18, 
                    ProductName = "Spitfire Mk.IXe ML407", 
                    Description = "Modelo de metal fundido premontado de alta calidad. Partes móviles, configuración de tren de aterrizaje extendido o retraído. Pintado y con marcas detalladas.", 
                    ImagePath="18.png", 
                    UnitPrice = 143.31, 
                    CategoryID = 3,
                    Age = 2002
                },
                    new Product
                {
                    ProductID = 19,
                    ProductName = "Air New Zealand Boeing",
                    Description = "El avión de radiocontrol accesible para todos gracias a un sistema de asistencia al pilotaje con giroscopio de 6 ejes.",
                    ImagePath="19.png",
                    UnitPrice = 550.000,
                    CategoryID = 3,
                    Age = 1977
                },
                    new Product
                {
                    ProductID = 20,
                    ProductName = "Glider 600",
                    Description = "El Glider 600 es un elegante y eficiente planeador diseñado para ofrecer una experiencia de vuelo suave y controlada. Ideal para entusiastas de la aviación que buscan calidad y rendimiento.",
                    ImagePath="30.png",
                    UnitPrice = 120.000,
                    CategoryID = 3,
                    Age = 1988
                },
                    new Product
                {
                    ProductID = 26,
                    ProductName = "Normandie Vintage Crucero",
                    Description = "Este modelo no es un juguete jugable, no se puede poner en el agua. Gran decoración y regalo, se puede utilizar como decoración de oficina, hogar o tienda, también para coleccionistas. Estado Nueva Escala 1/1250 Tamaño aproximado: 25 x 5 x 7,6 cm (largo, ancho, alto).",
                    ImagePath="26.png",
                    UnitPrice = 212.827,
                    CategoryID = 4,
                    Age = 2018
                },
                new Product
                {
                    ProductID = 27,
                    ProductName = "Cutty Sark",
                    Description = "El Cutty Sark es un clíper británico, velero clásico del siglo XIX, famoso por su belleza, gracia y velocidad, construido en Inglaterra en 1869. El 16 de febrero de 1870, el Cutty Sark partió de Londres en su viaje inaugural, navegando a Shanghái por el Cabo de Buena Esperanza.",
                    ImagePath="27.png",
                    UnitPrice = 330.000,
                    CategoryID = 4,
                    Age = 2019
                },
                new Product
                {
                    ProductID = 28,
                    ProductName = "Polaco Lilla Weneda",
                    Description = "3D Escala Polaco Lilla Weneda Flota del Báltico Ferry costero DIY Modelo de barco de papel Juego de rompecabezas Coleccionables, Material de papel, seguro y ecológico. El diseño de empalme se produce de forma inteligente.",
                    ImagePath="28.png",
                    UnitPrice = 81.143,
                    CategoryID = 4,
                    Age = 2019
                },
                new Product
                {
                    ProductID = 21,
                    ProductName = " Transbordador Atlantis",
                    Description = "El transbordador Atlantis fue el penúltimo construido en el programa espacial de la NASA. El Atlantis despegó por primera vez el 3 de octubre de 1985 y se convirtió en el primer transbordador en lanzar una sonda interplanetaria a Venus en 1989. ",
                    ImagePath="21.png",
                    UnitPrice = 79.000,
                    CategoryID = 5,
                    Age = 2022
                },
                new Product
                {
                    ProductID = 22,
                    ProductName = "Enterprise NCC-1701",
                    Description = "Los modelos de Revell están marcados con una escala del 1 al 5 por su nivel de dificultad de armado. Este en particular es de nivel 3. Está en escala 1:600, consta de 177 partes y mide 48,1 cms. de largo.\r\nEsta es por supuesto la versión del USS Enterprise más clásica, y por eso una de las más buscadas, en especial por los que crecieron viendo Star Trek en los años ’60.\r\n",
                    ImagePath="22.png",
                    UnitPrice = 181.528,
                    CategoryID = 5,
                    Age = 2004
                }, 
                new Product 
                { 
                    ProductID = 23, 
                    ProductName = " Millennium Falcon", 
                    Description = "The Millennium Falcon is a fictional spaceship that appears in the Star Wars film franchise. It is a modified Corellian freighter that became home to a band of smugglers and Rebel Alliance heroes. The Millennium Falcon is one of the most iconic spaceships in cinema history and has been praised for its unique design and its role in the Star Wars stories.", 
                    ImagePath="Falcon.png", 
                    UnitPrice = 922.000, 
                    CategoryID = 5,
                    Age = 2015
                },
                new Product
                {
                    ProductID = 24,
                    ProductName = "Estrella de la Muerte",
                    Description = "Los modelos de Revell están marcados con una escala del 1 al 5 por su nivel de dificultad de armado. Este en particular es de nivel 3. Está en escala 1:600, consta de 177 partes y mide 48,1 cms. de largo.\r\nEsta es por supuesto la versión del USS Enterprise más clásica, y por eso una de las más buscadas, en especial por los que crecieron viendo Star Trek en los años ’60.\r\n",
                    ImagePath="24.png",
                    UnitPrice = 495.069,
                    CategoryID = 5,
                    Age = 2009
                },
                new Product
                {
                    ProductID = 25,
                    ProductName = "Caza Tie Bombardeo",
                    Description = "El TIE Bombardero era capaz de realizar ataques devastadores con una gran precisión, ya fuese contra objetivos de superficie o en el espacio profundo.",
                    ImagePath="25.png",
                    UnitPrice = 84.256,
                    CategoryID = 5,
                    Age = 2005
                },
      }; 
 
      return products; 
    } 
  } 
} 