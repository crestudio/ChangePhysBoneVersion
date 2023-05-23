#if UNITY_EDITOR
using System.Collections.Generic;
using System.Linq;

using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

using VRC.SDK3.Dynamics.PhysBone.Components;

/*
 * VRSuya Change PhysBone Version
 * Contact : vrsuya@gmail.com // Twitter : https://twitter.com/VRSuya
 */

namespace VRSuya.ChangePhysBoneVersion {

    public class ChangePhysBoneVersion : EditorWindow {

		[MenuItem("Tools/VRSuya/PhysBone/Change All PhysBone Version to 1.0")]
		static void ChangePhysBoneVersionTo1_0() {
			List<VRCPhysBone> PhysBoneComponents = GetPhysBoneComponents();
			foreach (VRCPhysBone PhysBone in PhysBoneComponents) {
				PhysBone.version = VRC.Dynamics.VRCPhysBoneBase.Version.Version_1_0;
				EditorUtility.SetDirty(PhysBone);
			}
			Debug.Log("[VRSuya] Changed All PhysBone Version to 1.0");
		}

		[MenuItem("Tools/VRSuya/PhysBone/Change All PhysBone Version to 1.1")]
		static void ChangePhysBoneVersionTo1_1() {
			List<VRCPhysBone> PhysBoneComponents = GetPhysBoneComponents();
			foreach (VRCPhysBone PhysBone in PhysBoneComponents) {
				PhysBone.version = VRC.Dynamics.VRCPhysBoneBase.Version.Version_1_1;
				EditorUtility.SetDirty(PhysBone);
			}
			Debug.Log("[VRSuya] Changed All PhysBone Version to 1.1");
		}

		[MenuItem("Tools/VRSuya/PhysBone/Debug All PhysBone Version")]
		static void DebugLogPhysBoneComponets() {
			List<VRCPhysBone> PhysBoneComponents = GetPhysBoneComponents();
			foreach (VRCPhysBone PhysBone in PhysBoneComponents) {
				Debug.Log("[VRSuya] PhysBone Parent GameObject Name : " + PhysBone.name + " / Current Version : " + PhysBone.version);
			}
		}

		static List<VRCPhysBone> GetPhysBoneComponents() {
			return SceneManager.GetActiveScene().GetRootGameObjects().SelectMany(gameObject => gameObject.GetComponentsInChildren<VRCPhysBone>(true)).ToList();
		}
	}
}
#endif