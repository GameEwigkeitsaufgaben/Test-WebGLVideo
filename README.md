# WebGL Video

There are still problems when it comes to playing a video in WebGL. Although the video plays with no issues in the editor, the build is not rendered in WebGL. The video stays black or the video audio is fine but it is still black.

Developerpatform: Windows 10, Unity 2020.3.18f1

| Run Mode    |Tested |
| :---        |:---:  |
| Editor Mode | <ul><li>- [x] </li></ul> |
| Local Mode  | <ul><li>- [x] </li></ul> |
| Remote Mode | <ul><li>- [x] </li></ul> |

Video & Unity
ScenePlainVideoPlayer: Use a Videoplayer Component to play a Video on an GameObject.
SceneVideoFullScreen: Create a Videoplayer GameObject (Hierarchy), create a Render Texture(Project), create RawImage (Hierarchy) with Texture Render Texture, strech Transform; 
