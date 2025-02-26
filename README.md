# Construir imagen docker
- docker build -t rotatematrixapi
# Ejecutar el contenedor
- docker run -p 8080:80 rotatematrixapi
# Uso de la API
- http://localhost:8080/api/matrix/rotate
- Body : {
    "matrix": [[1,2,3],[4,5,6],[7,8,9]]
  }

  ## Resultado
  ![Imagen de WhatsApp 2025-02-25 a las 23 44 05_9dfe2abd](https://github.com/user-attachments/assets/c0c1d444-5457-4ab0-bf75-67b25b95dcb3)

