#pragma warning disable CS0626

using MonoMod;
using Modding.API;

[MonoModPatch("global::AddCamerasToManager")]
class AddCamerasToManagerPatch : AddCamerasToManager {

    public extern void orig_Start();
    public void Start() {
        orig_Start();

        ThirdPersonAPI.ActivateThirdPerson();
    }

}
