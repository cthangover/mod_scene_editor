# Editor de escenas — lugares de una novela sin JSON escrito a mano

El editor de escenas es una ventana sobre el juego en marcha para los lugares de una novela visual: los fondos de la escena, su sonido, su escenario por defecto y la lista de sus escenarios. El juego conoce al instante una escena guardada, e **▶ Ir a la escena** te lleva allí, así que puedes construir un lugar y entrar en él sin reiniciar.

## Cómo abrirlo

Pulsa el botón del martillo en la barra del juego y elige **Editor de escenas** en la caja de herramientas. La ventana sigue abierta al cambiar de escena; se puede mover, redimensionar y cerrar con la cruz.

## Un lugar nuevo

![El editor de escenas con my_novel_town de la plantilla de novela seleccionada: la lista de escenas a la izquierda, el fondo town_entry en el centro y entre los fondos de la escena, Guardar en my_novel_game y el escenario my_novel_town a la derecha.](assets/scene-editor.jpg)

1. Pulsa **+ Nueva escena**, escribe el id de la escena (letras latinas, cifras y `_`; `switch_scene` y las cabeceras de escenario se refieren a él) y elige el mod en **Guardar en**.
2. Elige un fondo en la lista y pulsa **+ Añadir fondo a la escena** (o haz doble clic). Una escena puede tener varios fondos; al entrar se elige uno al azar.
3. Elige un **Sonido** (el botón de reproducir permite escucharlo) y, si quieres, el **Escenario por defecto**, que se juega cuando no queda ningún otro escenario de la escena.
4. **Guardar** (Ctrl+S) escribe `scenes/<id>.json` en el mod elegido.
5. **+ Nuevo escenario** crea un archivo de escenario de esta escena en el mod elegido. Con `scenario_editor` instalado, el archivo se abre allí enseguida; **Abrir** (o doble clic) abre un escenario existente de la escena.
6. **▶ Ir a la escena** termina el diálogo en curso y entra en la escena.

## De quién son los archivos que se escriben

Una escena es la suma de los archivos `scenes/<id>.json` de todos los mods. El editor escribe solo el archivo del mod elegido en **Guardar en**, y solo se pueden elegir mods instalados como carpetas. Los fondos y ajustes que vienen de archivos de otros mods se muestran bloqueados; editar una escena ajena crea en tu mod un archivo que la completa. **Borrar** elimina solo el archivo del mod elegido.

## Si algo va mal

- **Abrir está en gris.** El editor de escenarios no está instalado; añade `scenario_editor` (o el conjunto Herramientas de desarrollo). Aun así se pueden crear archivos de escenario nuevos.
- **Guardar en no muestra mods.** Solo se puede escribir en mods de carpeta; los mods `.zip` empaquetados son de solo lectura.
- **Falta un fondo o sonido nuevo en las listas.** Pulsa **Volver a escanear** después de añadir archivos a un mod.

## Dependencias

`tools_base`, `scenario_tools_base`, `dialog_base`, `ui_base`. Opcional: `scenario_editor` para **Abrir**.
El paquete antiguo `editor_tools` instala este mod junto con las demás ventanas de autor.
