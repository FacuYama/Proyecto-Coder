/*MISC*/
/*PARTIALS*/
.header .navegation ul li {
  display: inline-block; }
  .header .navegation ul li .navegation ul li a {
    display: block;
    padding: 5px;
    font-family: Arial, Helvetica, sans-serif;
    align-items: center;
    transition: all 0.6s linear;
    border-radius: 5px; }
  .header .navegation ul li .navegation ul li a:hover {
    background-color: #c5c5c5; }

.header .menu {
  list-style-type: none;
  display: flex;
  justify-content: center;
  justify-content: space-evenly;
  gap: 1rem;
  align-items: center; }
  .header .menu .logovertical {
    height: 70px;
    align-items: center;
    background-color: white; }
  .header .menu .logovertical {
    transition: transform 4s; }
  .header .menu .logovertical:hover {
    transform: scale(1.2);
    background-color: white; }
  .header .menu .color:hover {
    color: black; }
  .header .menu .color {
    color: black;
    padding: 10px 30px;
    font-size: 22px;
    text-decoration: none;
    display: inline-block;
    transition: color 2s;
    align-items: center; }

/*FOOTER*/
footer {
  width: 100%;
  padding: 50px 0px;
  background-color: #c7c7c7; }
  footer .container__footer {
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
    max-width: 1200px;
    margin: auto;
    margin-top: 5px; }
    footer .container__footer .box__footer {
      display: flex;
      flex-direction: column;
      padding: 40px; }
      footer .container__footer .box__footer .logo {
        transition: transform 1.5s; }
        footer .container__footer .box__footer .logo .box__footer .logo img {
          width: 180px; }
      footer .container__footer .box__footer .logo:hover {
        transform: scale(1.2); }
      footer .container__footer .box__footer .box__footer .terminos {
        max-width: 350px;
        margin-top: 20px;
        font-weight: 500;
        color: #7a7a7a;
        font-size: 18px; }
      footer .container__footer .box__footer .box__footer h3 {
        margin-bottom: 30px;
        color: #343434;
        font-weight: 700; }
      footer .container__footer .box__footer .box__footer a {
        margin-top: 10px;
        color: #7a7a7a;
        font-weight: 600; }
        footer .container__footer .box__footer .box__footer a:hover {
          opacity: 0.8; }
        footer .container__footer .box__footer .box__footer a .box__footer a .fa-brands {
          font-size: 20px; }
  footer .box_copyright {
    max-width: 1200px;
    margin: auto;
    text-align: center;
    padding: 0px 40px; }
    footer .box_copyright .box_copyright p {
      margin-top: 20px;
      color: #7a7a7a; }
    footer .box_copyright .box_copyright hr {
      border: none;
      height: 2px;
      background-color: #7a7a7a; }

/*VIEWS*/
/*HOME*/
.descripcion {
  position: relative;
  left: 11rem;
  width: 600px;
  padding: 10px;
  display: block;
  font-family: Cambria, Cochin, Georgia, Times, 'Times New Roman', serif;
  font-size: 20px;
  text-align: justify;
  color: #313030; }
  .descripcion .descripcion-titulo {
    background-color: #baff6c; }

.videos {
  text-align: center; }
  .videos .video-titulo {
    padding: 5rem;
    font-size: 40px; }

.contenedor {
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  flex-direction: row; }
  .contenedor .cajas {
    /* background-color: darksalmon; */
    height: 500px;
    width: 400px;
    font-size: 20px;
    /* border: 3px solid grey; */
    box-sizing: border-box;
    margin: 5rem 5rem 7rem 5rem;
    text-align: justify; }
    .contenedor .cajas .titulo-cajas {
      background-color: #baff6c; }
