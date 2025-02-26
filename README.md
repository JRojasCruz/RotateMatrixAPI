# Construir imagen docker
- docker build -t rotatematrixapi
# Ejecutar el contenedor
- docker run -p 8080:80 rotatematrixapi
# Uso de la API
- http://localhost:8080/api/matrix/rotate
- Body : {
    "matrix": [[1,2,3],[4,5,6],[7,8,9]]
  }
