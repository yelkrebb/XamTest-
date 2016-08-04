using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/qcl/vh/a/a",
						"com/qcl/vh/a/b",
						"com/qcl/vh/a/c",
						"com/qcl/vh/a/d",
						"com/qcl/vh/a/e",
						"com/qcl/vh/b",
						"com/qcl/vh/b/a",
						"com/qcl/vh/b/b",
						"com/qcl/vh/ble/a",
						"com/qcl/vh/c/a",
						"com/qcl/vh/content",
						"com/qcl/vh/content/a",
						"com/qcl/vh/decoder/a",
						"com/qcl/vh/md/and",
						"com/qcl/vh/md/asthmapolis",
						"com/qcl/vh/md/fora",
						"com/qcl/vh/md/jnj",
						"com/qcl/vh/md/resmed",
						"com/qcl/vh/md/spirotel",
						"com/qcl/vh/md/vitalograph",
						"com/qcl/vh/utility",
					},
					new Converter<string, Type>[]{
						lookup_com_qcl_vh_a_a_package,
						lookup_com_qcl_vh_a_b_package,
						lookup_com_qcl_vh_a_c_package,
						lookup_com_qcl_vh_a_d_package,
						lookup_com_qcl_vh_a_e_package,
						lookup_com_qcl_vh_b_package,
						lookup_com_qcl_vh_b_a_package,
						lookup_com_qcl_vh_b_b_package,
						lookup_com_qcl_vh_ble_a_package,
						lookup_com_qcl_vh_c_a_package,
						lookup_com_qcl_vh_content_package,
						lookup_com_qcl_vh_content_a_package,
						lookup_com_qcl_vh_decoder_a_package,
						lookup_com_qcl_vh_md_and_package,
						lookup_com_qcl_vh_md_asthmapolis_package,
						lookup_com_qcl_vh_md_fora_package,
						lookup_com_qcl_vh_md_jnj_package,
						lookup_com_qcl_vh_md_resmed_package,
						lookup_com_qcl_vh_md_spirotel_package,
						lookup_com_qcl_vh_md_vitalograph_package,
						lookup_com_qcl_vh_utility_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_qcl_vh_a_a_mappings;
		static Type lookup_com_qcl_vh_a_a_package (string klass)
		{
			if (package_com_qcl_vh_a_a_mappings == null) {
				package_com_qcl_vh_a_a_mappings = new string[]{
					"com/qcl/vh/a/a/if:Com.Qcl.VH.A.A.If",
					"com/qcl/vh/a/a/If:Com.Qcl.VH.A.A.If",
				};
			}

			return Lookup (package_com_qcl_vh_a_a_mappings, klass);
		}

		static string[] package_com_qcl_vh_a_b_mappings;
		static Type lookup_com_qcl_vh_a_b_package (string klass)
		{
			if (package_com_qcl_vh_a_b_mappings == null) {
				package_com_qcl_vh_a_b_mappings = new string[]{
					"com/qcl/vh/a/b/if:Com.Qcl.VH.A.B.If",
					"com/qcl/vh/a/b/If:Com.Qcl.VH.A.B.If",
				};
			}

			return Lookup (package_com_qcl_vh_a_b_mappings, klass);
		}

		static string[] package_com_qcl_vh_a_c_mappings;
		static Type lookup_com_qcl_vh_a_c_package (string klass)
		{
			if (package_com_qcl_vh_a_c_mappings == null) {
				package_com_qcl_vh_a_c_mappings = new string[]{
					"com/qcl/vh/a/c/if:Com.Qcl.VH.A.C.If",
					"com/qcl/vh/a/c/If:Com.Qcl.VH.A.C.If",
				};
			}

			return Lookup (package_com_qcl_vh_a_c_mappings, klass);
		}

		static string[] package_com_qcl_vh_a_d_mappings;
		static Type lookup_com_qcl_vh_a_d_package (string klass)
		{
			if (package_com_qcl_vh_a_d_mappings == null) {
				package_com_qcl_vh_a_d_mappings = new string[]{
					"com/qcl/vh/a/d/if:Com.Qcl.VH.A.D.If",
					"com/qcl/vh/a/d/If:Com.Qcl.VH.A.D.If",
				};
			}

			return Lookup (package_com_qcl_vh_a_d_mappings, klass);
		}

		static string[] package_com_qcl_vh_a_e_mappings;
		static Type lookup_com_qcl_vh_a_e_package (string klass)
		{
			if (package_com_qcl_vh_a_e_mappings == null) {
				package_com_qcl_vh_a_e_mappings = new string[]{
					"com/qcl/vh/a/e/if:Com.Qcl.VH.A.E.If",
					"com/qcl/vh/a/e/If:Com.Qcl.VH.A.E.If",
				};
			}

			return Lookup (package_com_qcl_vh_a_e_mappings, klass);
		}

		static string[] package_com_qcl_vh_b_mappings;
		static Type lookup_com_qcl_vh_b_package (string klass)
		{
			if (package_com_qcl_vh_b_mappings == null) {
				package_com_qcl_vh_b_mappings = new string[]{
					"com/qcl/vh/b/if:Com.Qcl.VH.B.If",
					"com/qcl/vh/b/If:Com.Qcl.VH.B.If",
				};
			}

			return Lookup (package_com_qcl_vh_b_mappings, klass);
		}

		static string[] package_com_qcl_vh_b_a_mappings;
		static Type lookup_com_qcl_vh_b_a_package (string klass)
		{
			if (package_com_qcl_vh_b_a_mappings == null) {
				package_com_qcl_vh_b_a_mappings = new string[]{
					"com/qcl/vh/b/a/if:Com.Qcl.VH.B.A.If",
				};
			}

			return Lookup (package_com_qcl_vh_b_a_mappings, klass);
		}

		static string[] package_com_qcl_vh_b_b_mappings;
		static Type lookup_com_qcl_vh_b_b_package (string klass)
		{
			if (package_com_qcl_vh_b_b_mappings == null) {
				package_com_qcl_vh_b_b_mappings = new string[]{
					"com/qcl/vh/b/b/if:Com.Qcl.VH.B.B.If",
				};
			}

			return Lookup (package_com_qcl_vh_b_b_mappings, klass);
		}

		static string[] package_com_qcl_vh_ble_a_mappings;
		static Type lookup_com_qcl_vh_ble_a_package (string klass)
		{
			if (package_com_qcl_vh_ble_a_mappings == null) {
				package_com_qcl_vh_ble_a_mappings = new string[]{
					"com/qcl/vh/ble/a/if:Com.Qcl.VH.Ble.A.If",
					"com/qcl/vh/ble/a/If:Com.Qcl.VH.Ble.A.If",
				};
			}

			return Lookup (package_com_qcl_vh_ble_a_mappings, klass);
		}

		static string[] package_com_qcl_vh_c_a_mappings;
		static Type lookup_com_qcl_vh_c_a_package (string klass)
		{
			if (package_com_qcl_vh_c_a_mappings == null) {
				package_com_qcl_vh_c_a_mappings = new string[]{
					"com/qcl/vh/c/a/if:Com.Qcl.VH.C.A.If",
				};
			}

			return Lookup (package_com_qcl_vh_c_a_mappings, klass);
		}

		static string[] package_com_qcl_vh_content_mappings;
		static Type lookup_com_qcl_vh_content_package (string klass)
		{
			if (package_com_qcl_vh_content_mappings == null) {
				package_com_qcl_vh_content_mappings = new string[]{
					"com/qcl/vh/content/if:Com.Qcl.VH.Content.If",
					"com/qcl/vh/content/If:Com.Qcl.VH.Content.If",
				};
			}

			return Lookup (package_com_qcl_vh_content_mappings, klass);
		}

		static string[] package_com_qcl_vh_content_a_mappings;
		static Type lookup_com_qcl_vh_content_a_package (string klass)
		{
			if (package_com_qcl_vh_content_a_mappings == null) {
				package_com_qcl_vh_content_a_mappings = new string[]{
					"com/qcl/vh/content/a/if:Com.Qcl.VH.Content.A.If",
					"com/qcl/vh/content/a/If:Com.Qcl.VH.Content.A.If",
				};
			}

			return Lookup (package_com_qcl_vh_content_a_mappings, klass);
		}

		static string[] package_com_qcl_vh_decoder_a_mappings;
		static Type lookup_com_qcl_vh_decoder_a_package (string klass)
		{
			if (package_com_qcl_vh_decoder_a_mappings == null) {
				package_com_qcl_vh_decoder_a_mappings = new string[]{
					"com/qcl/vh/decoder/a/If:Com.Qcl.VH.Decoder.A.If",
				};
			}

			return Lookup (package_com_qcl_vh_decoder_a_mappings, klass);
		}

		static string[] package_com_qcl_vh_md_and_mappings;
		static Type lookup_com_qcl_vh_md_and_package (string klass)
		{
			if (package_com_qcl_vh_md_and_mappings == null) {
				package_com_qcl_vh_md_and_mappings = new string[]{
					"com/qcl/vh/md/and/if:Com.Qcl.VH.MD.And.If",
					"com/qcl/vh/md/and/If:Com.Qcl.VH.MD.And.If",
				};
			}

			return Lookup (package_com_qcl_vh_md_and_mappings, klass);
		}

		static string[] package_com_qcl_vh_md_asthmapolis_mappings;
		static Type lookup_com_qcl_vh_md_asthmapolis_package (string klass)
		{
			if (package_com_qcl_vh_md_asthmapolis_mappings == null) {
				package_com_qcl_vh_md_asthmapolis_mappings = new string[]{
					"com/qcl/vh/md/asthmapolis/if:Com.Qcl.VH.MD.Asthmapolis.If",
					"com/qcl/vh/md/asthmapolis/If:Com.Qcl.VH.MD.Asthmapolis.If",
				};
			}

			return Lookup (package_com_qcl_vh_md_asthmapolis_mappings, klass);
		}

		static string[] package_com_qcl_vh_md_fora_mappings;
		static Type lookup_com_qcl_vh_md_fora_package (string klass)
		{
			if (package_com_qcl_vh_md_fora_mappings == null) {
				package_com_qcl_vh_md_fora_mappings = new string[]{
					"com/qcl/vh/md/fora/If:Com.Qcl.VH.MD.Fora.If",
				};
			}

			return Lookup (package_com_qcl_vh_md_fora_mappings, klass);
		}

		static string[] package_com_qcl_vh_md_jnj_mappings;
		static Type lookup_com_qcl_vh_md_jnj_package (string klass)
		{
			if (package_com_qcl_vh_md_jnj_mappings == null) {
				package_com_qcl_vh_md_jnj_mappings = new string[]{
					"com/qcl/vh/md/jnj/if:Com.Qcl.VH.MD.Jnj.If",
					"com/qcl/vh/md/jnj/If:Com.Qcl.VH.MD.Jnj.If",
				};
			}

			return Lookup (package_com_qcl_vh_md_jnj_mappings, klass);
		}

		static string[] package_com_qcl_vh_md_resmed_mappings;
		static Type lookup_com_qcl_vh_md_resmed_package (string klass)
		{
			if (package_com_qcl_vh_md_resmed_mappings == null) {
				package_com_qcl_vh_md_resmed_mappings = new string[]{
					"com/qcl/vh/md/resmed/if:Com.Qcl.VH.MD.Resmed.If",
				};
			}

			return Lookup (package_com_qcl_vh_md_resmed_mappings, klass);
		}

		static string[] package_com_qcl_vh_md_spirotel_mappings;
		static Type lookup_com_qcl_vh_md_spirotel_package (string klass)
		{
			if (package_com_qcl_vh_md_spirotel_mappings == null) {
				package_com_qcl_vh_md_spirotel_mappings = new string[]{
					"com/qcl/vh/md/spirotel/if:Com.Qcl.VH.MD.Spirotel.If",
				};
			}

			return Lookup (package_com_qcl_vh_md_spirotel_mappings, klass);
		}

		static string[] package_com_qcl_vh_md_vitalograph_mappings;
		static Type lookup_com_qcl_vh_md_vitalograph_package (string klass)
		{
			if (package_com_qcl_vh_md_vitalograph_mappings == null) {
				package_com_qcl_vh_md_vitalograph_mappings = new string[]{
					"com/qcl/vh/md/vitalograph/if:Com.Qcl.VH.MD.Vitalograph.If",
					"com/qcl/vh/md/vitalograph/If:Com.Qcl.VH.MD.Vitalograph.If",
				};
			}

			return Lookup (package_com_qcl_vh_md_vitalograph_mappings, klass);
		}

		static string[] package_com_qcl_vh_utility_mappings;
		static Type lookup_com_qcl_vh_utility_package (string klass)
		{
			if (package_com_qcl_vh_utility_mappings == null) {
				package_com_qcl_vh_utility_mappings = new string[]{
					"com/qcl/vh/utility/if:Com.Qcl.VH.Utility.If",
					"com/qcl/vh/utility/If:Com.Qcl.VH.Utility.If",
				};
			}

			return Lookup (package_com_qcl_vh_utility_mappings, klass);
		}
	}
}
