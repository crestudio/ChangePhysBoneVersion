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

namespace com.vrsuya.changephysboneversion {

    public class ChangePhysBoneVersion : EditorWindow {

		[MenuItem("Tools/VRSuya/PhysBone/Change All PhysBone Version to 1.0")]
		/// <summary>Scene에 존재하는 모든 PhysBone을 1.0으로 변경합니다</summary>
		static void ChangePhysBoneVersionTo1_0() {
			List<VRCPhysBone> PhysBoneComponents = GetPhysBoneComponents();
			foreach (VRCPhysBone PhysBone in PhysBoneComponents) {
				PhysBone.version = VRC.Dynamics.VRCPhysBoneBase.Version.Version_1_0;
				EditorUtility.SetDirty(PhysBone);
			}
			Debug.Log("[VRSuya] Changed All PhysBone Version to 1.0");
		}

		[MenuItem("Tools/VRSuya/PhysBone/Change All PhysBone Version to 1.1")]
		/// <summary>Scene에 존재하는 모든 PhysBone을 1.1으로 변경합니다</summary>
		static void ChangePhysBoneVersionTo1_1() {
			List<VRCPhysBone> PhysBoneComponents = GetPhysBoneComponents();
			foreach (VRCPhysBone PhysBone in PhysBoneComponents) {
				PhysBone.version = VRC.Dynamics.VRCPhysBoneBase.Version.Version_1_1;
				EditorUtility.SetDirty(PhysBone);
			}
			Debug.Log("[VRSuya] Changed All PhysBone Version to 1.1");
		}

		[MenuItem("Tools/VRSuya/PhysBone/Debug All PhysBone Version")]
		/// <summary>Scene에 존재하는 모든 PhysBone의 버전을 Unity Console에 출력합니다</summary>
		static void DebugLogPhysBoneComponets() {
			List<VRCPhysBone> PhysBoneComponents = GetPhysBoneComponents();
			foreach (VRCPhysBone PhysBone in PhysBoneComponents) {
				Debug.Log("[VRSuya] PhysBone Parent GameObject Name : " + PhysBone.name + " / Current Version : " + PhysBone.version);
			}
		}

		/// <summary>Scene에 존재하는 모든 PhysBone의 리스트를 가져옵니다</summary>
		/// <returns>Scene에 존재하는 모든 PhysBone 컴포넌트 리스트</returns>
		static List<VRCPhysBone> GetPhysBoneComponents() {
			return SceneManager.GetActiveScene().GetRootGameObjects().SelectMany(gameObject => gameObject.GetComponentsInChildren<VRCPhysBone>(true)).ToList();
		}
	}
}
#endif