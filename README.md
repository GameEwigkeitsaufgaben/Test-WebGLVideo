# WebGL Video

There are still problems when it comes to playing a video in WebGL. Although the video plays with no issues in the editor, the build is not rendered in WebGL. The video stays black or the video audio is fine but it is still black.

Developerpatform: Windows 10, Unity 2020.3.18f1

| Run Mode    |Tested |
| :---        |:---:  |
| Editor Mode | <ul><li>- [x] </li></ul> |
| Local Mode  | <ul><li>- [x] </li></ul> |
| Remote Mode | <ul><li>- [x] </li></ul> |

Video & Unity
+ It is possilbe tu use a Videoplayer Component and apply it directly to a GameObject. This way works not with WebGL.
+ Only setup with RenderTexture, VideoplayerScript and RawImage is working. 
+ With the RenderTexture Setup, videos are playing. On Chrome there is a play on awake problem, chrome seems to need any kind of userinput before player a video (problem may occur when reload the scene!!!) 
+ If there is a choppy video (although the sound/audio is good), try to clear cache data (images, video) in chorme.

WebGL: https://gameewigkeitsaufgaben.github.io/Test-WebGLVideo/


1) Projekt anlegen
2) In Textures eine RenderTexture anlegen. Keine Änderungen vornehmen.
3) VideoPlayer anlegen: Einstellungen Ändern Disable Play on Awake, Scip on Drop. Target Texture dir RenderTexture reinziehen. 
4) Script namens WebGLVideoPlayer anlegen bzw. hier kopieren: https://github.com/GameEwigkeitsaufgaben/Test-WebGLVideo/blob/main/Assets/MyGame/Scripts/WebGlVideoPlayer.cs
5) Ein GameObject anlegen und WebGLVideoPlayer raufziehen. 

