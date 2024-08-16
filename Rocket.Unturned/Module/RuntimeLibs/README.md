## Runtime Libraries

Here we just store the runtime libraries that are used by the Rocket or other plugins. These libraries are not included in the plugin itself, but are required to be present in the Module directory in order for Rocket itself and the other plugins to work correctly.

## Add/Update Runtime Library

To add/update a Runtime Library, we provide these options (they're different ways):

# Option #1
- Have installed Mono/Unity Editor with the same version as in Unturned.
- To find the necessary library: `Program Files\Mono\lib\mono\gac` or also you can try this place: `Program Files\Mono\lib\mono\4.5\Facades`.

# Option #2
- Copy the necessary libraries from [OpenMod](https://github.com/openmod/openmod) runtime libs or release of the module, this way we keep as close as possible same libraries.

You can also check this [post](https://sunnamed434.github.io/posts/assemblyresolve-and-mono/) to understand things better about libraries, specifically in Unity.