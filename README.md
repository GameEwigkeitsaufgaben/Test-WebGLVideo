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
+ With the RenderTexture Setup, videos are playing. On Chrome there is a play on awake problem, chome seems to need any kind of userinput before player a video (problem may occur when relod the scene!!!) 

Setup
SceneVideoFullScreen: Create a Videoplayer GameObject (Hierarchy), create a Render Texture(Project), create RawImage (Hierarchy) with Texture Render Texture, strech Transform; 
