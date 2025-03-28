# Taller 1: Stonehenge libremente adaptado
_Por José Cerezo_

Para este taller, decidí hacer una escena sencilla que representara al monumento megalítico [StoneHenge](https://es.wikipedia.org/wiki/Stonehenge) con ciertas modificaciones geográficas por fines del trabajo.

En este trabajo se usaron materiales descargados de la Unity Asset Store, más específicamente los diseñados por LowlyPoly:
- [Stylized Grass Texture](https://assetstore.unity.com/packages/2d/textures-materials/glass/stylized-grass-texture-153153)
- [Stylized Stones Texture](https://assetstore.unity.com/packages/2d/textures-materials/floors/stylized-stones-texture-153460)
- [Stylize Snow Texture](https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-snow-texture-153579)
Y el diseñado por Nobiax / Yughues: [Yughues Free Stone Materials](https://assetstore.unity.com/packages/2d/textures-materials/stone/yughues-free-stone-materials-12962)

Las montañas fueron hechas usando la herramienta enseñada en clase: Terrain Tools, al igual que las texturas que tienen estas. Los layers del terreno se crearon manualmente y se asignaron las texturas en un orden coherente (primero la hierba, luego la roca y por último la nieve, para que quedaran una encima de otra).

Se realizó un script para permitir al jugador moverse por la escena utilizando las teclas WASD y el mouse. Este no implementa colisiones, por lo que los objetos de la escena se pueden atravesar.

Por último, para el monumento se crearon dos prefabs: Roof y Pillar. Estos son cubos alargados y modificados que tienen un material puesto (el diseñado por Nobiax). Se crearon debido a que en Stonehenge, muchas de las piedras utilizadas son muy similares, por lo que se pueden reutilizar y no tener que modificar sus propiedades una y otra vez.
