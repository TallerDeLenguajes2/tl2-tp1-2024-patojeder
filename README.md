a) El pedido y el cliente es una rekacion de composicion, ya que si no existe un cliente no habra pedido.
La relacion pedido/cadete es de agregacion, puede existir un pedido, independientemente si existe un cadete o no.
La relacion cadete/cadeteria es de agregacion. Una cadeteria puede no tener cadetes.

b) La clase cadete debe tener un metodo que me cree un cadete con todos sus datos.
La clase cadeteria, deberia tener un metodo que reciba una lista de cadetes y conforme los datos de la cadeteria.

c)Deben ser publicos los metodos que me muestren los datos del pedido, cadeteria. Deben ser privados, los datos personales del cadete, 

d) un constructor vacio por defecto para ambas clases. Para el constructor de cadete, un metodo que reciba todos los datos, menos los pedidods, que estara inicializado en null. Para el constructor de la cadeteria, el metodo debe recibir el nombre de la cadeteria, el numero del recinto y una lista con los datos de los cadetes.