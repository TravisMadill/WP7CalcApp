using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace FinalPhoneApp
{
    /// <summary>
    /// This class has all the logic flow and that. The Arithmetic class has all the equations and formulas and such.
    /// </summary>
	public partial class MainPage : PhoneApplicationPage
	{
		/// <summary>
		/// The last result calculated if the equation contains more than one operation.
		/// </summary>
		public double lastResults = 0.0;

		/// <summary>
		/// A potential constant for in case the "=" button is pressed consecutively without anything else being pressed.
		/// Constant being the number to add or subtract or multiply or divide by.
		/// </summary>
		public double potentialConstant = 0.0;

		/// <summary>
		/// Whether or not the calulation is starting. Used to help determine the potentialConstant value if applicable.
		/// </summary>
		public bool isStarting = true;

		/// <summary>
		/// The current operation that was being requested to do.
		/// </summary>
		public string curOperation = "none";

		/// <summary>
		/// Whether or not the calculator is showing inverse functions right now.
		/// Determines what to do if a button that has an inverse function does.
		/// </summary>
		public bool showingInvFns = false;

		/// <summary>
		/// Whether or not there was an error calculating something, like dividing by zero.
		/// Pretty much no button can be pressed if there is an error, except for the "C" button.
		/// </summary>
		public bool thereWasError = false;

		/// <summary>
		/// Whether or not the number in the result box is in degrees or radians. I would have put in gradians, but
        /// I didn't want to confuse myself, since I have math this semester, too. Also determines what to for
        /// the trig functions.
		/// </summary>
		public bool isInDegMode = true;

		public MainPage()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Adds a zero to the result box. Does nothing if the box text = "0"
        /// </summary>
		private void btn_0_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text != "0")
						outResults.Text += "0";
				}
			}
		}

        /// <summary>
        /// Adds a one to the result box.
        /// </summary>
		private void btn_1_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "1";
					else
						outResults.Text += "1";
				}
			}
		}

        /// <summary>
        /// Adds a two to the result box.
        /// </summary>
		private void btn_2_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "2";
					else
						outResults.Text += "2";
				}
			}
		}

        /// <summary>
        /// Adds a three to the result box.
        /// </summary>
		private void btn_3_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "3";
					else
						outResults.Text += "3";
				}
			}
		}

        /// <summary>
        /// Adds a four to the result box.
        /// </summary>
		private void btn_4_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "4";
					else
						outResults.Text += "4";
				}
			}
		}

        /// <summary>
        /// Adds a five to the result box.
        /// </summary>
		private void btn_5_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "5";
					else
						outResults.Text += "5";
				}
			}
		}

        /// <summary>
        /// Adds a six to the result box.
        /// </summary>
		private void btn_6_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "6";
					else
						outResults.Text += "6";
				}
			}
		}

        /// <summary>
        /// Adds a seven to the result box.
        /// </summary>
		private void btn_7_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "7";
					else
						outResults.Text += "7";
				}
			}
		}

        /// <summary>
        /// Adds an eight to the result box.
        /// </summary>
		private void btn_8_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "8";
					else
						outResults.Text += "8";
				}
			}
		}

        /// <summary>
        /// Adds a nine to the result box.
        /// </summary>
		private void btn_9_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length < 30)
				{
					if (outResults.Text == "0")
						outResults.Text = "9";
					else
						outResults.Text += "9";
				}
			}
		}

        /// <summary>
        /// Adds a decimal to the results box number to allow for decimals in numbers.
        /// </summary>
        private void btn_decimal_Click(object sender, RoutedEventArgs e)
        {
            if (!thereWasError)
            {
                outResults.Text += ".";
            }
        }

        /// <summary>
        /// Makes the result box text the pi constant, or 2 times pi if inverted.
        /// </summary>
		private void btn_pi_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (!showingInvFns)
					outResults.Text = Math.PI.ToString();
				else
					outResults.Text = (Math.PI * 2).ToString();
			}
		}

        /// <summary>
        /// Resets everything back to normal.
        /// </summary>
		private void btn_clearAll_Click(object sender, RoutedEventArgs e)
		{
			outResults.Text = "0";
			lastResults = 0.0;
			isStarting = true;
			thereWasError = false;
			potentialConstant = 0;
			outStatus.Text = Messages.clearAll;
		}

        /// <summary>
        /// Starts preparing for an addition equation.
        /// </summary>
		private void btn_add_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				try
				{
					if (isStarting) // If starting, there's no need to actually do anything besides store the number.
					{
						lastResults = Convert.ToDouble(outResults.Text);
						isStarting = false;
					}
					else //Otherwise, perform the last operation that was requested.
						performOperation();

                    //Display the results...
					outStatus.Text = Messages.addingNum.Replace("%s", lastResults.ToString());

                    //Reset the box...
					outResults.Text = "0";

                    //And say we're adding.
					curOperation = "add";
				}
				catch (OverflowException) //And if the number is too big, report an error.
				{
					outResults.Text = Messages.error_overflow;
					outStatus.Text = Messages.error_overflow;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Starts preparing for a subtraction equation.
        /// </summary>
		private void btn_subtract_Click(object sender, RoutedEventArgs e)
		{
            //This pretty much works the exact same as btn_add_Click, except for subtracting
			if (!thereWasError)
			{
				try
				{
					if (isStarting)
					{
						lastResults = Convert.ToDouble(outResults.Text);
						isStarting = false;
					}
					else
						performOperation();
					outStatus.Text = Messages.subtractNum.Replace("%s", lastResults.ToString());
					outResults.Text = "0";
					curOperation = "subtract";
				}
				catch (OverflowException)
				{
					outResults.Text = Messages.error_overflow;
					outStatus.Text = Messages.error_overflow;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Starts preparing for a multiplication equation.
        /// </summary>
		private void btn_multiply_Click(object sender, RoutedEventArgs e)
		{
            //This pretty much works the exact same as btn_add_Click, except for multiplying
			if (!thereWasError)
			{
				try
				{
					if (isStarting)
					{
						lastResults = Convert.ToDouble(outResults.Text);
						isStarting = false;
					}
					else
						performOperation();
					outStatus.Text = Messages.multiplyNum.Replace("%s", lastResults.ToString());
					outResults.Text = "0";
					curOperation = "mult";
				}
				catch (OverflowException)
				{
					outResults.Text = Messages.error_overflow;
					outStatus.Text = Messages.error_overflow;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Starts preparing for a division equation.
        /// </summary>
		private void btn_divide_Click(object sender, RoutedEventArgs e)
		{
            //This pretty much works the exact same as btn_add_Click, except for dividing
            // and there is a little more error trapping if the denominator that is being entered is zero.
			if (!thereWasError)
			{
				try
				{
					if (isStarting)
					{
						lastResults = Convert.ToDouble(outResults.Text);
						isStarting = false;
					}
					else
						performOperation();

					if (!thereWasError)
					{
						outStatus.Text = Messages.divideNum.Replace("%s", lastResults.ToString());
						outResults.Text = "0";
						curOperation = "divide";
						if (Double.IsInfinity(lastResults) || Double.IsNaN(lastResults))
						{
							outStatus.Text = Messages.error_DivZero;
							outResults.Text = Messages.error_DivZero;
							thereWasError = true;
						}
					}
				}
				catch (OverflowException)
				{
					outResults.Text = Messages.error_overflow;
					outStatus.Text = Messages.error_overflow;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Prepares to peform a division operation that gives the remainder of what is divided.
        /// </summary>
        private void btn_modulus_Click(object sender, RoutedEventArgs e)
        {
            //This pretty much works the exact same as btn_add_Click, except for modulus-ing
            // and there is the same error trapping as the division method.
            if (!thereWasError)
            {
                try
                {
                    if (isStarting)
                    {
                        lastResults = Convert.ToDouble(outResults.Text);
                        isStarting = false;
                    }
                    else
                        performOperation();
                    outStatus.Text = Messages.divideNum.Replace("%s", lastResults.ToString());
                    outResults.Text = "0";
                    curOperation = "mod";
                    if (Double.IsInfinity(lastResults) || Double.IsNaN(lastResults))
                    {
                        outStatus.Text = Messages.error_DivZero;
                        outResults.Text = Messages.error_DivZero;
                        thereWasError = true;
                    }
                }
                catch (OverflowException)
                {
                    outResults.Text = Messages.error_overflow;
                    outStatus.Text = Messages.error_overflow;
                    thereWasError = true;
                }
            }
        }

        /// <summary>
        /// Calculates the final results from the numbers given and the operation(s) requested.
        /// </summary>
        private void btn_calculate_Click(object sender, RoutedEventArgs e)
        {
            if (!thereWasError)
            {
                if (!isStarting) //The potential constant is usually from the last number entered.
                    potentialConstant = Convert.ToDouble(outResults.Text);
                switch (curOperation)
                {
                    case "add": //Show the results from adding...
                        if (!isStarting)
                            outResults.Text = (lastResults + Convert.ToDouble(outResults.Text)).ToString();
                        else
                            outResults.Text = (Convert.ToDouble(outResults.Text) + potentialConstant).ToString();
                        break;
                    case "subtract": //...or subtracting...
                        if (!isStarting)
                            outResults.Text = (lastResults - Convert.ToDouble(outResults.Text)).ToString();
                        else
                            outResults.Text = (Convert.ToDouble(outResults.Text) - potentialConstant).ToString();
                        break;
                    case "mult": //...or multiplying...
                        if (!isStarting)
                            outResults.Text = (lastResults * Convert.ToDouble(outResults.Text)).ToString();
                        else
                            outResults.Text = (Convert.ToDouble(outResults.Text) * potentialConstant).ToString();
                        break;
                    case "divide": //...or dividing...
                        if (!isStarting)
                        {
                            if (outResults.Text != "0") //Also if denominator is zero, throw an error.
                                outResults.Text = (lastResults / Convert.ToDouble(outResults.Text)).ToString();
                            else
                            {
                                outStatus.Text = Messages.error_DivZero;
                                outResults.Text = Messages.error_DivZero;
                                thereWasError = true;
                            }
                        }
                        else
                            outResults.Text = (Convert.ToDouble(outResults.Text) / potentialConstant).ToString();
                        break;
                    case "log": //...or logarithms...
                        if (Convert.ToDouble(outResults.Text) > 0)
                        {
                            outResults.Text = Arithmetic.nthLogBase(lastResults, Convert.ToDouble(outResults.Text)).ToString();
                        }
                        else //Logarithms can't have a negative number.
                        {
                            outResults.Text = Messages.error_InvNumber;
                            outStatus.Text = Messages.error_log.Replace("%s", Messages.error_log_base);
                            thereWasError = true;
                        }
                        break;
                    case "yroot": //...or custom roots...
                        double rootNum = Convert.ToDouble(outResults.Text);
                        if (rootNum % 2.0 == 0) //Root is even. No negatives allowed.
                        {
                            if (lastResults < 0)
                            {
                                outResults.Text = Messages.error_InvNumber;
                                outStatus.Text = Messages.error_InvNumber;
                                thereWasError = true;
                            }
                            else
                            {
                                outResults.Text = Arithmetic.nthRoot(lastResults, rootNum).ToString();
                            }
                        }
                        else //Root is odd. Negatives are allowed.
                        {
                            if (lastResults < 0)
                            {
                                //For some reason, this won't accept negative numbers... at all. So just add a negative sign if it's negative.
                                outResults.Text = "-" + Arithmetic.nthRoot(Math.Abs(lastResults), rootNum).ToString();
                            }
                            else
                            {
                                outResults.Text = Arithmetic.nthRoot(lastResults, rootNum).ToString();
                            }
                        }
                        break;
                    case "pow": //...or raising to powers...
                        outResults.Text = Arithmetic.nthPower(lastResults, Convert.ToDouble(outResults.Text)).ToString();
                        break;
                    case "mod": //...or the modulus operator.
                        if (!isStarting)
                        {
                            if (outResults.Text != "0")
                                outResults.Text = (lastResults % Convert.ToDouble(outResults.Text)).ToString();
                            else
                            {
                                outStatus.Text = Messages.error_DivZero;
                                outResults.Text = Messages.error_DivZero;
                                thereWasError = true;
                            }
                        }
                        else
                            outResults.Text = (Convert.ToDouble(outResults.Text) % potentialConstant).ToString();
                        break;
                }

                //Final result display if there was no error.
                if (!thereWasError)
                    outStatus.Text = Messages.equalNum;

                if (!thereWasError && (Double.IsInfinity(lastResults) || Double.IsInfinity(Convert.ToDouble(outResults.Text))))
                {
                    outResults.Text = Messages.error_overflow;
                    outStatus.Text = Messages.error_overflow;
                    thereWasError = true;
                }
                if (!thereWasError && (Double.IsNaN(lastResults) || Double.IsNaN(Convert.ToDouble(outResults.Text))))
                {
                    outResults.Text = Messages.error_InvNumber;
                    outStatus.Text = Messages.error_InvNumber;
                    thereWasError = true;
                }

                //Also, since the equal button was pressed, this is the final answer, and therefore, we're starting a new equation.
                isStarting = true;
            }
        }

        /// <summary>
        /// Performs the operation requested and stores the number in the lastResults variable.
        /// </summary>
		public void performOperation()
		{
            //For the most part, this is the same as the btn_calculate_Click, but not setting isStarting to true,
            // and storing the answer in the lastResults variable.
			if (!thereWasError)
			{
				try
				{
					switch (curOperation)
					{
						case "add":
							outResults.Text = (lastResults + Convert.ToDouble(outResults.Text)).ToString();
							lastResults = Convert.ToDouble(outResults.Text);
							break;
						case "subtract":
							outResults.Text = (lastResults - Convert.ToDouble(outResults.Text)).ToString();
							lastResults = Convert.ToDouble(outResults.Text);
							break;
						case "mult":
							outResults.Text = (lastResults * Convert.ToDouble(outResults.Text)).ToString();
							lastResults = Convert.ToDouble(outResults.Text);
							break;
						case "divide":
							if (outResults.Text != "0")
							{
								outResults.Text = (lastResults / Convert.ToDouble(outResults.Text)).ToString();
								lastResults = Convert.ToDouble(outResults.Text);
							}
							else
							{
								outStatus.Text = Messages.error_DivZero;
								outResults.Text = Messages.error_DivZero;
								thereWasError = true;
							}
							break;
						case "log":
							if (Convert.ToDouble(outResults.Text) > 0)
							{
								outResults.Text = Arithmetic.nthLogBase(lastResults, Convert.ToDouble(outResults.Text)).ToString();
								lastResults = Convert.ToDouble(outResults.Text);
							}
							else
							{
								outResults.Text = Messages.error_InvNumber;
								outStatus.Text = Messages.error_log.Replace("%s", Messages.error_log_base);
								thereWasError = true;
							}
							break;
						case "yroot":
							double rootNum = Convert.ToDouble(outResults.Text);
							if (rootNum % 2.0 == 0) //No negatives allowed
							{

								if (lastResults < 0)
								{
									outResults.Text = Messages.error_InvNumber;
									outStatus.Text = Messages.error_InvNumber;
									thereWasError = true;
								}
								else
								{
									outResults.Text = Arithmetic.nthRoot(lastResults, rootNum).ToString();
									lastResults = Convert.ToDouble(outResults.Text);
								}
							}
							else //Negatives allowed
							{
								if (lastResults < 0)
								{
									outResults.Text = "-" + Arithmetic.nthRoot(Math.Abs(lastResults), rootNum).ToString();
									lastResults = Convert.ToDouble(outResults.Text);
								}
								else
								{
									outResults.Text = Arithmetic.nthRoot(lastResults, rootNum).ToString();
									lastResults = Convert.ToDouble(outResults.Text);
								}
							}
							break;
						case "pow":
							outResults.Text = Arithmetic.nthPower(lastResults, Convert.ToDouble(outResults.Text)).ToString();
							lastResults = Convert.ToDouble(outResults.Text);
							break;
						case "mod":
							if (outResults.Text != "0")
							{
								outResults.Text = (lastResults % Convert.ToDouble(outResults.Text)).ToString();
								lastResults = Convert.ToDouble(outResults.Text);
							}
							else
							{
								outStatus.Text = Messages.error_DivZero;
								outResults.Text = Messages.error_DivZero;
								thereWasError = true;
							}
							break;
					}
					if (!thereWasError && (Double.IsInfinity(lastResults) || Double.IsInfinity(Convert.ToDouble(outResults.Text))))
					{
						outResults.Text = Messages.error_overflow;
						outStatus.Text = Messages.error_overflow;
						thereWasError = true;
					}
				}
                    //Also, catch those potential errors.
				catch (OverflowException)
				{
					outResults.Text = Messages.error_overflow;
					outStatus.Text = Messages.error_overflow;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Adds a negative sign to the number in the results box or removes it if it's already there.
        /// </summary>
		private void btn_invSign_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text != "0") //Multiplying by negative one acts as inverting the sign.
					outResults.Text = (Convert.ToDouble(outResults.Text) * -1).ToString();
			}
		}

        /// <summary>
        /// Makes the number in the results box the square root of the number originally in there.
        /// </summary>
		private void btn_sqrt_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (Convert.ToDouble(outResults.Text) >= 0)
					outResults.Text = Arithmetic.nthRoot(Convert.ToDouble(outResults.Text), 2).ToString();
				else //Square roots of negative numbers are impossible
				{
					outStatus.Text = Messages.error_InvNumber;
					outResults.Text = Messages.error_InvNumber;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Removes the last number inputted into the results box.
        /// For example: "57" now becomes "5"
        /// </summary>
		private void btn_bksp_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text.Length > 1)
				{
					outResults.Text = outResults.Text.Remove(outResults.Text.Length - 1);
				}
				else if (outResults.Text == "-")
					outResults.Text = "0";
				else
					outResults.Text = "0";

                //For some reason, this wouldn't work unless this was here.
				if (outResults.Text == "-")
					outResults.Text = "0";
			}
		}

        /// <summary>
        /// Resets the results box. The last results variable stays as is.
        /// </summary>
		private void btn_clearEntry_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				outResults.Text = "0";
				outStatus.Text = Messages.clearEntry.Replace("%s", lastResults.ToString());
			}
		}

        /// <summary>
        /// Reciprocates the number in the results box.
        /// For example: The number "2" becomes the results of "1/2", "0.5"
        /// </summary>
		private void btn_recip_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outResults.Text != "0") //Putting to the power of -1 acts as reciprocating the number.
					outResults.Text = Arithmetic.nthPower(Convert.ToDouble(outResults.Text), -1).ToString();
				else //And throw an error if the number is zero
				{
					outResults.Text = Messages.error_DivZero;
					outStatus.Text = Messages.error_DivZero;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Calculates the percentage of the two numbers entered.
        /// For example: 50% of 5 is 2.5 -> "50" * "5" "%" results in 2.5
        /// </summary>
		private void btn_percent_Click(object sender, RoutedEventArgs e)
		{
            //This kind of acts like the equals button, but divides/multiplies the answer by 100 for the percentage value.
            // There's also no yroot, log, pow and things like that relating to percentages.
			if (!thereWasError)
			{
				switch (curOperation)
				{
					case "add":
						outResults.Text = (lastResults * Convert.ToDouble(outResults.Text) / 100).ToString();
						outStatus.Text = Messages.percent_Add;
						break;
					case "subtract":
						outResults.Text = (lastResults * Convert.ToDouble(outResults.Text) / 100).ToString();
						outStatus.Text = Messages.percent_Subtract;
						break;
					case "mult":
						outResults.Text = (lastResults * Convert.ToDouble(outResults.Text) / 100).ToString();
						outStatus.Text = Messages.percent_Mult;
						break;
					case "divide":
						outResults.Text = (lastResults / Convert.ToDouble(outResults.Text) * 100).ToString();
						break;
				}
				if (Double.IsInfinity(lastResults) || Double.IsInfinity(Convert.ToDouble(outResults.Text)))
				{
					outStatus.Text = Messages.error_DivZero;
					outResults.Text = Messages.error_DivZero;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Adds the number in the results box to the memory.
        /// </summary>
		private void btn_memAdd_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				outThereIsMemory.Text = "M";
				Arithmetic.Memory += Convert.ToDouble(outResults.Text);
				outStatus.Text = Messages.memStatus.Replace("%s", Arithmetic.Memory.ToString());
			}
		}

        /// <summary>
        /// Subtracts the number in the results box to the memory.
        /// </summary>
		private void btn_memSubtract_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				outThereIsMemory.Text = "M";
				Arithmetic.Memory -= Convert.ToDouble(outResults.Text);
				outStatus.Text = Messages.memStatus.Replace("%s", Arithmetic.Memory.ToString());
			}
		}

        /// <summary>
        /// Replaces the number in the results box with what's currently in the memory.
        /// </summary>
		private void btn_memRecall_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (outThereIsMemory.Text == "M")
				{
					outResults.Text = Arithmetic.Memory.ToString();
				}
				else
				{
					outStatus.Text = Messages.noMemStored;
				}
			}
		}

        /// <summary>
        /// Resets the memory back to zero.
        /// </summary>
        private void btn_memClear_Click(object sender, RoutedEventArgs e)
        {
            if (!thereWasError)
            {
                Arithmetic.Memory = 0;
                outThereIsMemory.Text = "";
                outStatus.Text = Messages.memCleared;
            }
        }

        /// <summary>
        /// Performs the factorial of the number in the results box.
        /// </summary>
        private void btn_factorial_Click(object sender, RoutedEventArgs e)
        {
            if (!thereWasError)
            {
                if (Convert.ToDouble(outResults.Text) > 0)
                {
                    outStatus.Text = Messages.factorialBtn;
                    outResults.Text = Arithmetic.factorial((int)Math.Floor(Convert.ToDouble(outResults.Text))).ToString();
                }
                else
                {
                    outResults.Text = Messages.error_InvNumber;
                    outStatus.Text = Messages.error_InvNumber;
                    thereWasError = true;
                }

                //If it's too much, just say so.
                if (outResults.Text == "Infinity")
                {
                    outResults.Text = Messages.error_overflow;
                    outStatus.Text = Messages.error_overflow;
                    thereWasError = true;
                }
            }
        }

        /// <summary>
        /// Prepares for performing a logarithm operation with a custom base.
        /// </summary>
		private void btn_log_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (Convert.ToDouble(outResults.Text) > 0)
				{
					lastResults = Convert.ToDouble(outResults.Text);
					curOperation = "log";
					outStatus.Text = Messages.logWithBaseGetBase;
					outResults.Text = "0";
					isStarting = false;
				}
				else //Can't take logs of negative numbers.
				{
					outResults.Text = Messages.error_InvNumber;
					outStatus.Text = Messages.error_log.Replace("%s", Messages.error_log_subject);
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Makes the number in the results box the loagrithm (base 10) of the number originally in there.
        /// </summary>
		private void btn_log10_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (Convert.ToDouble(outResults.Text) > 0)
					outResults.Text = Arithmetic.nthLogBase(Convert.ToDouble(outResults.Text), 10).ToString();
				else //Still can't take logs of negative numbers.
				{
					outResults.Text = Messages.error_InvNumber;
					outStatus.Text = Messages.error_log.Replace("%s", Messages.error_log_subject);
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Replaces the number in the results box with the logarithm (base e) of the number entered or the number raised by the constant e.
        /// </summary>
        private void btn_natLog_Click(object sender, RoutedEventArgs e)
        {
            if (!thereWasError)
            {
                if (!showingInvFns)
                {
                    if (Convert.ToDouble(outResults.Text) > 0)
                        outResults.Text = Arithmetic.nthLogBase(Convert.ToDouble(outResults.Text), Math.E).ToString();
                    else
                    {
                        outResults.Text = Messages.error_InvNumber;
                        outStatus.Text = Messages.error_log.Replace("%s", Messages.error_log_subject);
                        thereWasError = true;
                    }
                }
                else
                {
                    outResults.Text = Math.Exp(Convert.ToDouble(outResults.Text)).ToString();

                    //If it's too much, just say so.
                    if (outResults.Text == "Infinity")
                    {
                        outResults.Text = Messages.error_overflow;
                        outStatus.Text = Messages.error_overflow;
                        thereWasError = true;
                    }
                }
            }
        }

        /// <summary>
        /// Squares the number in the results box.
        /// </summary>
		private void btn_square_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				outResults.Text = Arithmetic.nthPower(Convert.ToDouble(outResults.Text), 2).ToString();

                //If it's too much, just say so.
				if (outResults.Text == "Infinity")
				{
					outResults.Text = Messages.error_overflow;
					outStatus.Text = Messages.error_overflow;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Raises the number in the results box to the power of 1/3
        /// </summary>
		private void btn_cubeRoot_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				double numToRoot = Convert.ToDouble(outResults.Text);
				if (numToRoot < 0)
				{
					outResults.Text = "-" + Arithmetic.nthRoot(Math.Abs(numToRoot), 3).ToString();
				}
				else
				{
					outResults.Text = Arithmetic.nthRoot(numToRoot, 3).ToString();
				}
			}
		}

        /// <summary>
        /// Prepares to raise the number in the result box to the power of 1/y, the y being filled in later.
        /// </summary>
		private void btn_yRoot_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				lastResults = Convert.ToDouble(outResults.Text);
				curOperation = "yroot";
				outStatus.Text = Messages.nthRootGetRoot;
				outResults.Text = "0";
				isStarting = false;
			}
		}

        /// <summary>
        /// Cubes the number in the results box.
        /// </summary>
		private void btn_cube_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				outResults.Text = Arithmetic.nthPower(Convert.ToDouble(outResults.Text), 3).ToString();

                //If it's too much, just say so.
				if (outResults.Text == "Infinity")
				{
					outResults.Text = Messages.error_overflow;
					outStatus.Text = Messages.error_overflow;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Prepares to raise the number in the results box to an exponent.
        /// </summary>
		private void btn_exponent_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				lastResults = Convert.ToDouble(outResults.Text);
				curOperation = "pow";
				outStatus.Text = Messages.powerGetPower;
				outResults.Text = "0";
				isStarting = false;
			}
		}

        /// <summary>
        /// Inverts the functions on the buttons that use inverse functions.
        /// </summary>
        private void btn_invFns_Click(object sender, RoutedEventArgs e)
        {
            if (!showingInvFns)
            {
                outStatus.Text = Messages.nowInverseFns;
                btn_natLog.Content = Messages.ln_Inv;
                btn_invFns.Content = Messages.invFunc_Inv;
                btn_pi.Content = Messages.pi_Inv;
                btn_sine.Content = Messages.sin_Inv;
                btn_cosine.Content = Messages.cos_Inv;
                btn_tangent.Content = Messages.tan_Inv;
                showingInvFns = true;
            }
            else
            {
                outStatus.Text = Messages.nowNormalFns;
                btn_natLog.Content = Messages.ln_noInv;
                btn_invFns.Content = Messages.invFunc_noInv;
                btn_pi.Content = Messages.pi_noInv;
                btn_sine.Content = Messages.sin_noInv;
                btn_cosine.Content = Messages.cos_noInv;
                btn_tangent.Content = Messages.tan_noInv;
                showingInvFns = false;
            }
        }

        /// <summary>
        /// Changes the number in the results box to degrees. Also, trig functions will now all use degrees.
        /// </summary>
		private void chk_degMode_Checked(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (!isInDegMode)
				{
					outStatus.Text = Messages.nowDegMode;
					isInDegMode = true;
					outResults.Text = Arithmetic.toDegrees(Convert.ToDouble(outResults.Text)).ToString();
				}
			}
		}

        /// <summary>
        /// Changes the number in the results box to radians. Also, trig functions will now all use radians.
        /// </summary>
		private void chk_radMode_Checked(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (isInDegMode)
				{
					outStatus.Text = Messages.nowRadMode;
					isInDegMode = false;
					outResults.Text = Arithmetic.toRadians(Convert.ToDouble(outResults.Text)).ToString();
				}
			}
		}

        /// <summary>
        /// Performs the sine function on the number in the result box. The result depends on if the calculator is in degree or radian mode.
        /// It also depends on whether or not it is currently showing inverse functions or not.
        /// </summary>
		private void btn_sine_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (!showingInvFns)
				{
					if (isInDegMode)
						outResults.Text = Arithmetic.degSine(Convert.ToDouble(outResults.Text)).ToString();
					else
						outResults.Text = Arithmetic.radSine(Convert.ToDouble(outResults.Text)).ToString();
				}
				else
				{
					if (isInDegMode)
						outResults.Text = Arithmetic.degInvSine(Convert.ToDouble(outResults.Text)).ToString();
					else
						outResults.Text = Arithmetic.radInvSine(Convert.ToDouble(outResults.Text)).ToString();
				}

                //If anything here causes this, it'll be inverse sine.
				if (outResults.Text == "NaN")
				{
					outResults.Text = Messages.error_InvNumber;
					outStatus.Text = Messages.error_invSine;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Performs the cosine function on the number in the result box. The result depends on if the calculator is in degree or radian mode.
        /// It also depends on whether or not it is currently showing inverse functions or not.
        /// </summary>
		private void btn_cosine_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				if (!showingInvFns)
				{
					if (isInDegMode)
						outResults.Text = Arithmetic.degCosine(Convert.ToDouble(outResults.Text)).ToString();
					else
						outResults.Text = Arithmetic.radCosine(Convert.ToDouble(outResults.Text)).ToString();
				}
				else
				{
					if (isInDegMode)
						outResults.Text = Arithmetic.degInvCosine(Convert.ToDouble(outResults.Text)).ToString();
					else
						outResults.Text = Arithmetic.radInvCosine(Convert.ToDouble(outResults.Text)).ToString();
				}

                //If anything here causes this, it'll be inverse cosine.
				if (outResults.Text == "NaN")
				{
					outResults.Text = Messages.error_InvNumber;
					outStatus.Text = Messages.error_invCosine;
					thereWasError = true;
				}
			}
		}

        /// <summary>
        /// Performs the tangent function on the number in the result box. The result depends on if the calculator is in degree or radian mode.
        /// It also depends on whether or not it is currently showing inverse functions or not.
        /// </summary>
		private void btn_tangent_Click(object sender, RoutedEventArgs e)
		{
			if (!thereWasError)
			{
				double numTangent = Convert.ToDouble(outResults.Text);
				if (!showingInvFns)
				{
					if (isInDegMode)
						outResults.Text = Arithmetic.degTangent(Convert.ToDouble(outResults.Text)).ToString();
					else
						outResults.Text = Arithmetic.radTangent(Convert.ToDouble(outResults.Text)).ToString();
				}
				else
				{
					if (isInDegMode)
						outResults.Text = Arithmetic.degInvTangent(Convert.ToDouble(outResults.Text)).ToString();
					else
						outResults.Text = Arithmetic.radInvTangent(Convert.ToDouble(outResults.Text)).ToString();
				}

                //If anything here causes this, it'll be tangent.
				if (outResults.Text == "NaN" || outResults.Text == "Infinity")
				{
					outStatus.Text = Messages.error_tangentAsymptotes.Replace("%s", numTangent.ToString());
					outResults.Text = Messages.error_InvNumber;
					thereWasError = true;
				}
			}
		}
	}
}