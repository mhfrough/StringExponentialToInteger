using System;
using System.Collections.Generic;

namespace StringExponentialToInteger
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			while (true) {
				string input = Console.ReadLine ();

				if (input.Contains ("-"))
					MinusExponential (input);
				else
					PlusExponential (input);

				Console.WriteLine ("\n");
			}
		}

		public static void PlusExponential(string input){
			string[] data1, data2;

			data1 = input.Split ('.');
			data2 = data1 [1].Split ('e');

			long value1 = 0, value2 = 0;
			string temp1, temp2;

			value1 = LongConvert (data2 [1]);
			temp1 = data1 [0] + data2 [0];
			value2 = value1 - data2 [0].Length;

			if (value2 <= 0) {
				value2 = value2 * (-1);
				temp2 = "1" + ZeroConvert (value2);
				float point = (float)LongConvert(temp1) / (float)LongConvert(temp2);
				Console.WriteLine (point);
			} else {
				temp1 = temp1 + ZeroConvert (value2);
				Console.WriteLine (LongConvert (temp1));
			}
				
		}

		public static void MinusExponential(string input){

			string[] data1, data2, data3;

			data1 = input.Split ('.');
			data2 = data1 [1].Split ('e');
			data3 = data2 [1].Split ('-');

			long value1 = 0, value2 = 0;
			string temp1, temp2;

			value1 = LongConvert (data3 [1]);
			temp1 = data1 [0] + data2 [0];
			value2 = value1 + data2 [0].Length;
			temp2 = "1" + ZeroConvert(value2);

			float point = (float)LongConvert(temp1) / (float)LongConvert(temp2);
			Console.WriteLine (point);
		}

		public static long LongConvert(string data){
			Dictionary<char, long> dict = new Dictionary<char, long> ();
			dict.Add ('0', 0); dict.Add ('1', 1); dict.Add ('2', 2);
			dict.Add ('3', 3); dict.Add ('4', 4); dict.Add ('5', 5);
			dict.Add ('6', 6); dict.Add ('7', 7); dict.Add ('8', 8);
			dict.Add ('9', 9);

			long value = 0;
			foreach (var item in data) {
				value = value * 10 + dict [item];
			}
			return value;
		}

		public static string ZeroConvert(long value){
			

			string data = "";
			for (long i = 0; i < value; i++) {
				data = data + 0;
			}
			return data;
		}
	}
}
