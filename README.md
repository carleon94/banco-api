# Banco
- Compilar solucion
- Cambiar en archivo appsettings.json las credenciales "SqlConnection" para apuntar a base local de prueba
- Cambiar en archivo BancoInfrastructure/Contexto/BancoContexto.cs las credenciales del metodo "UseSqlServer" para apuntar a base local de prueba
 
# Ejecutar Script en Sql Server Management Studio
CREATE Database BancoDB

use BancoDB

```sql
CREATE TABLE categorias (
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	Nombre VARCHAR(256) NOT NULL,
	Codigo VARCHAR(50) NOT NULL UNIQUE
)

CREATE TABLE productos (
	Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT NEWID(),
	CategoriaId UNIQUEIDENTIFIER NOT NULL FOREIGN KEY REFERENCES categorias(Id) DEFAULT NEWID(),
	Nombre VARCHAR(256) NOT NULL,
	Codigo VARCHAR(50) NOT NULL UNIQUE,
	Descripcion VARCHAR(MAX) NOT NULL,
	ImageUrl VARCHAR(MAX),
	Favorito BIT,
	Precio DECIMAL(18,2),
	Stock INT,
	Tienda VARCHAR(500)
)


INSERT INTO categorias ( nombre , codigo ) 
VALUES
('Computadoras' , 'compu-01'),
('Laptops' , 'laptop-01'),
('Celulares' , 'cell-01')



INSERT INTO productos ( CategoriaId , nombre , codigo , Descripcion , ImageUrl , Favorito , Precio , Stock , Tienda ) 
VALUES
( 
	(SELECT TOP 1 Id FROM categorias where codigo = 'compu-01') 
	, 'iBUYPOWER Trace 7 Mesh' 
	, 'pc-01'
	, 'Computadora de escritorio para juegos TMA7N3501'
	, 'https://m.media-amazon.com/images/I/818pGIMxwBL._AC_SX466_.jpg' 
	, 0 
	, 1200.56 
	, 30 
	, 'Amazon' 
),
( 
	(SELECT TOP 1 Id FROM categorias where codigo = 'laptop-01') 
	, 'HP Computadora portátil 14' 
	, 'lp-01'
	, 'Intel Celeron N4020, 4 GB de RAM, 64 GB'
	, 'https://m.media-amazon.com/images/I/815uX7wkOZS._AC_SX466_.jpg' 
	, 0 
	, 2500.23 
	, 102 
	, 'Alibaba' 
),
( 
	(SELECT TOP 1 Id FROM categorias where codigo = 'cell-01') 
	, 'SAMSUNG Galaxy A35 5G Serie A'
	, 'sm-01'
	, 'Teléfono inteligente Android desbloqueado de 128 GB, pantalla AMOLED, sistema avanzado de triple cámara, almacenamiento ampliable, diseño resistente'
	, 'https://m.media-amazon.com/images/I/71YwZXmVcEL._AC_SX679_.jpg'
	, 0
	, 958.34
	, 356
	, 'Samsung'
),

( 
	(SELECT TOP 1 Id FROM categorias where codigo = 'cell-01') 
	, 'SAMSUNG Galaxy S24 Ultra'
	, 'sm-02'
	, 'Teléfono inteligente AI de 256 GB, Android desbloqueado, 200 MP, cámaras zoom 100x, batería de larga duración, S Pen, versión estadounidense, 2024, negro'
	, 'https://m.media-amazon.com/images/I/71WcjsOVOmL._AC_SX679_.jpg'
	, 0
	, 1456.21
	, 54
	, 'Samsung'
),

( 
	(SELECT TOP 1 Id FROM categorias where codigo = 'cell-01') 
	, 'SAMSUNG Galaxy A15 5G Serie A'
	, 'sm-03'
	, 'Teléfono inteligente Android desbloqueado de 128 GB, pantalla AMOLED, almacenamiento ampliable, seguridad Knox, carga súper rápida, versión'
	, 'https://m.media-amazon.com/images/I/41vU1u8DZXL._AC_SX679_.jpg'
	, 0
	, 238.15
	, 23
	, 'Samsung'
)
```
