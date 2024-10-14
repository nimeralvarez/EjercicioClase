using EjercicioClase;

SuperHeroe superHeroe1=new SuperHeroe();
superHeroe1.Nombre = "Superman";
superHeroe1.IdentidadSecreta = "Clark Kent";
superHeroe1.Ciudad = "Metrópolis";
superHeroe1.PuedeVolar = true;
superHeroe1.Superpoder.Nombre = "Super fuerza";
superHeroe1.Superpoder.Descripcion = "Capacidad de levantar objetos muy pesados";
superHeroe1.Superpoder.Nivel = 9;
superHeroe1.Imprimir();

SuperHeroe superHeroe2 = new SuperHeroe();
superHeroe2.Nombre = "Batman";
superHeroe2.IdentidadSecreta = "Bruce Wayne";
superHeroe2.Ciudad = "Gótica";
superHeroe2.PuedeVolar = false;
superHeroe2.Superpoder.Nombre = "No tiene super poderes";
superHeroe2.Superpoder.Descripcion = "Recurre a su intelecto";
superHeroe2.Superpoder.Nivel = 0;
superHeroe2.Imprimir();

SuperHeroe superHeroe3 = new SuperHeroe();
superHeroe3.Nombre = "Spider-Man";
superHeroe3.IdentidadSecreta = "Peter Parker";
superHeroe3.Ciudad = "Nueva York";
superHeroe3.PuedeVolar = false;
superHeroe3.Superpoder.Nombre = "Crear redes arácnidos";
superHeroe3.Superpoder.Descripcion = "Capacidad de sentido arácnido";
superHeroe3.Superpoder.Nivel = 6;
superHeroe3.Imprimir();