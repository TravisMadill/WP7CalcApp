
namespace FinalPhoneApp
{
	public class Messages
	{
		//Button strings before inverse
		public static string ln_noInv = "ln";
		public static string invFunc_noInv = "f⁻¹(x)";
		public static string pi_noInv = "π";
		public static string sin_noInv = "sin";
		public static string cos_noInv = "cos";
		public static string tan_noInv = "tan";

		//Button strings after inverse
		public static string ln_Inv = "eˣ";
		public static string invFunc_Inv = "f(x)";
		public static string pi_Inv = "2π";
		public static string sin_Inv = "sin⁻¹";
		public static string cos_Inv = "cos⁻¹";
		public static string tan_Inv = "tan⁻¹";

		//General messages for status text
		public static string addingNum = "Adding %s.";
		public static string subtractNum = "Subtracting %s.";
		public static string multiplyNum = "Multiplying %s.";
		public static string divideNum = "Dividing %s.";
		public static string equalNum = "Answer is...";
		public static string factorialBtn = "Only the whole number is used for factorials. Any decimals are ignored.";
		public static string clearAll = "Cleared everything.";
		public static string clearEntry = "Entry cleared. Previous result is still %s.";
		public static string percent_Mult = "This is the percentage of the value entered.";
		public static string percent_Add = "This is the percentage of the value entered. Press \"=\" for this to be added.";
		public static string percent_Subtract = "This is the percentage of the value entered. Press \"=\" for this to be subtracted.";
		public static string error_DivZero = "You can't divide by zero!";
		public static string error_InvNumber = "Can't use that number!";
		public static string error_overflow = "Too much!";
        public static string error_log = "A logarithm's %s can only be greater than zero.";
        public static string error_log_base = "base";
        public static string error_log_subject = "subject";
		public static string error_tangentAsymptotes = "tan(%s) is undefined there.";
		public static string error_invSine = "Inverse sine is only defined for ratios between -1 and 1.";
		public static string error_invCosine = "Inverse cosine is only defined for ratios between -1 and 1.";
		public static string error_General = "It's interesting that you can see this.";
		public static string memStatus = "Memory is now %s.";
		public static string memCleared = "The memory was cleared.";
		public static string noMemStored = "There's nothing stored in the memory!";
		public static string nowInverseFns = "Showing inverse functions.";
		public static string nowNormalFns = "Showing normal functions.";
		public static string powerGetPower = "Now enter the exponent. Note: All previous values have been forgotten.";
		public static string nthRootGetRoot = "Now enter the root number. Note: All previous values have been forgotten.";
		public static string logWithBaseGetBase = "Now enter the logarithm's base. Note: All previous values have been forgotten.";
		public static string nowDegMode = "Now displaying number as degrees. All trig functions now only use degrees.";
		public static string nowRadMode = "Now displaying number as radians. All trig functions now only use radians.";
	}
}
