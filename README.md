GESTION DE ALUMNOS Y ASIGNATURAS

Este software permite la gestion de alumnos y asignaturas mediante el uso de CRUD(crear, leer , actualizar , eliminar) en una base de sql server (Sql Server Management Studio 20) desarrollada en Windows form Utilizando C#

COMO USAR LA APLICACION

------Gestión de Alumnos------

Crear Alumnos: Selecciona la opción Agregar Alumno e ingresa los datos solicitados: nombre, apellido, email y número de matrícula. Completa todos los campos y presiona Guardar.

Consultar Alumnos: En la pantalla principal, se muestra un listado de todos los alumnos en un DataGridView.

Actualizar Alumnos: Selecciona un alumno de la lista y elige la opción Editar Alumno. Modifica los datos y confirma para actualizar el registro.

Eliminar Alumnos: Selecciona un alumno de la lista y presiona el botón Eliminar Alumno. Confirma la acción para eliminar el registro.

-------Gestión de Asignaturas-------

Crear Asignaturas: Selecciona Agregar Asignatura e ingresa el nombre de la asignatura y el número de créditos. Completa todos los campos y presiona Guardar.

Consultar Asignaturas: En la pantalla principal, se muestra un listado de todas las asignaturas en un DataGridView.

Actualizar Asignaturas: Selecciona una asignatura de la lista y elige la opción Editar Asignatura. Modifica los datos y confirma para actualizar el registro.

Eliminar Asignaturas: Selecciona una asignatura de la lista y presiona el botón Eliminar Asignatura. Confirma la acción para eliminar el registro.

ESTRUCTURA DEL PROYECTO

ayaT2 (Capa de Presentación): Interfaz de usuario donde se muestran y gestionan las operaciones de CRUD para alumnos y asignaturas. 
ayaBOL(Capa de objetos de negocio): La capa ayaBOL contiene las clases que representan los objetos de negocio en la aplicación, específicamente las clases Alumnos y Asignatura 
ayaDAL (Capa de Acceso a Datos): Gestiona las operaciones de la base de datos, incluyendo la conexión y ejecución de comandos SQL para almacenar, actualizar y eliminar registros. 
ayaBL(Capa de lógica de negocio): se encarga de procesar las solicitudes del usuario y coordinar las operaciones de Crear, Leer, Actualizar y Eliminar (CRUD).
