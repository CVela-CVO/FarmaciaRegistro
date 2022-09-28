<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
<!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>

</head>
<div class="container"  >¡Todo lo necesario para una buena salud!</div>
<body>
<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
<a class="navbar-brand" href="index.php">
    <img src="logo.png" width="30" height="30" class="d-inline-block align-top" alt="">
    Farmacia Bethesda
  </a>

    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarText">
        <ul class="navbar-nav mr-auto">
        <li class="nav-item active">
            <a class="nav-link" href="index.php">Inicio<span class="sr-only"></span></a>
        </li>
        <li class="nav-item">
            <a class="nav-link" href="catalogo.php">Catálogo de Medicamentos</a>
        </li>
        </ul>
    </div>
</nav>

            
            <font size="5">
            <?php
            $user = "root";
            $pass = "";
            $host = "localhost";
            $coneccion = mysqli_connect($host, $user, $pass);
            if(!$coneccion)
                    {
                        echo "No se ha podido conectar con el servidor" . mysql_error();
                    }

            $DB = "registrofarmacia";
            $dbselect = mysqli_select_db($coneccion,$DB);
            if (!$dbselect)
            {
            echo "No se ha podido encontrar la base de Datos";
            }

            $consulta = "SELECT m.id_medicamento as 'ID', m.name_medicamento as 'Nombre',m.precio_medicamento as 'Precio',m.medica_existencias as 'Existencia', m.img_medicamento as 'Fotografía' , ma.ico_marca as 'Logotipo de Marca',  m.obs_medicamento as 'Observación', dis.name_distribuidora as 'Distribuidora', m.costo_medicamento as 'Costo' FROM medicamento m INNER JOIN distribuidoras dis ON m.id_distribuidora = dis.id_distribuidora INNER JOIN marca ma ON m.id_marca = ma.id_marca;";
            $result = mysqli_query($coneccion,$consulta);

            if(!$result)
            {
                echo "No se ha podido realizar la consulta";
            };
            echo '<table class="table table-dark table-striped-columns">';
            echo "<tr>";
            echo '<th scope="col"><h1>ID</th></h1>';
            echo '<th scope="col"><h1>Medicamento</th></h1>';
            echo '<th scope="col"><h1>Precio</th></h1>';
            echo '<th scope="col"><h1>Observación</th></h1>';  
            echo '<th scope="col"><h1>Existencia</th></h1>';
            echo '<th scope="col"><h1>Fotografía</th></h1>';
            echo '<th scope="col"><h1>Marca</th></h1>';                    
            echo '<th scope="col"><h1>Distribuidora</th></h1>';
            echo '<th scope="col"><h1>Costo</th></h1>';
            echo "</tr>";
            while ($colum = mysqli_fetch_array($result))
            {
                echo "<tr>";
                echo "<td><h2>" . $colum['ID']. "</td></h2>";
                echo "<td><h2>" . $colum['Nombre'] . "</td></h2>";
                echo "<td><h2>Q" . $colum['Precio'] . "</td></h2>";
                echo "<td><h2>" . $colum['Observación'] . "</td></h2>";
                echo "<td><h2>" . $colum['Existencia'] . "</td></h2>";
                echo "<td><h2><img src= ImgFarmacia/Productos/" . $colum['Fotografía'] . " width=190></td></h2>";
                echo "<td><h2><img src= ImgFarmacia/Marcas/" . $colum['Logotipo de Marca'] . " width=190></td></h2>";               
                echo "<td><h2>" . $colum['Distribuidora'] . "</td></h2>";
                echo "<td><h2>Q" . $colum['Costo'] . "</td></h2>";
                echo "</tr>";
            }
            echo "</table>"; ?>
        
            <style>
        html, body{
          margin: 0;
          padding: 0;
      
      }
      body{
          width: 100%;
          height: 100%;
          font-family: sans-serif;
          letter-spacing: 0.03em;
          line-height: 1.6;
      
      }
      .title{
          text-align: center;
          font-size: 40px;
          color: #6a6a6a;
          margin-top: 100px;
          font-family: 'Roboto', sans-serif;
      
      }
      
      .container{
          width: auto;
          max-width: auto;
          height: auto;
          display: flex;
          flex-wrap: wrap;
          justify-content: center;
          overflow: hidden;
      }
      .container .card{
          width: 275px;
          height: auto;
          border-radius: 8px;
          box-shadow: 0 2px 2px rgba(0, 0, 0.2);
          overflow: hidden;
          margin: 20px;
          text-align: center;
          transition: all 0,25s;
          float: left;
      
      }
      .container .card:hover{
          transform: translate(-15px);
          box-shadow: 0 12px 16px rgba(0, 0, 0.2);
      
      }
      
      .container .card img{
          width: 330px;
          height: 220px;
      }
      
      .container .card img{
          font-weight: 600;
      }
      .container .card p{
          padding: 0 2rem;
          font-weight: 400;
          font-size: 14px;
      }
      
      
      .container .card a{
          font-weight: 500;
          text-decoration: none;
          color: #3498db;
      }
        </style>
        </body>
</html>