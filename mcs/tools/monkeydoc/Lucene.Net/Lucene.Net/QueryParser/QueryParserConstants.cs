/* 
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/* Generated By:JavaCC: Do not edit this line. QueryParserConstants.java */

using System;

namespace Mono.Lucene.Net.QueryParsers
{
	
	
	/// <summary> Token literal values and constants.
	/// Generated by org.javacc.parser.OtherFilesGen#start()
	/// </summary>
	public class QueryParserConstants
	{
		/// <summary>End of File. </summary>
		public const int EOF = 0;
		/// <summary>RegularExpression Id. </summary>
		public const int _NUM_CHAR = 1;
		/// <summary>RegularExpression Id. </summary>
		public const int _ESCAPED_CHAR = 2;
		/// <summary>RegularExpression Id. </summary>
		public const int _TERM_START_CHAR = 3;
		/// <summary>RegularExpression Id. </summary>
		public const int _TERM_CHAR = 4;
		/// <summary>RegularExpression Id. </summary>
		public const int _WHITESPACE = 5;
		/// <summary>RegularExpression Id. </summary>
		public const int _QUOTED_CHAR = 6;
		/// <summary>RegularExpression Id. </summary>
		public const int AND = 8;
		/// <summary>RegularExpression Id. </summary>
		public const int OR = 9;
		/// <summary>RegularExpression Id. </summary>
		public const int NOT = 10;
		/// <summary>RegularExpression Id. </summary>
		public const int PLUS = 11;
		/// <summary>RegularExpression Id. </summary>
		public const int MINUS = 12;
		/// <summary>RegularExpression Id. </summary>
		public const int LPAREN = 13;
		/// <summary>RegularExpression Id. </summary>
		public const int RPAREN = 14;
		/// <summary>RegularExpression Id. </summary>
		public const int COLON = 15;
		/// <summary>RegularExpression Id. </summary>
		public const int STAR = 16;
		/// <summary>RegularExpression Id. </summary>
		public const int CARAT = 17;
		/// <summary>RegularExpression Id. </summary>
		public const int QUOTED = 18;
		/// <summary>RegularExpression Id. </summary>
		public const int TERM = 19;
		/// <summary>RegularExpression Id. </summary>
		public const int FUZZY_SLOP = 20;
		/// <summary>RegularExpression Id. </summary>
		public const int PREFIXTERM = 21;
		/// <summary>RegularExpression Id. </summary>
		public const int WILDTERM = 22;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEIN_START = 23;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEEX_START = 24;
		/// <summary>RegularExpression Id. </summary>
		public const int NUMBER = 25;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEIN_TO = 26;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEIN_END = 27;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEIN_QUOTED = 28;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEIN_GOOP = 29;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEEX_TO = 30;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEEX_END = 31;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEEX_QUOTED = 32;
		/// <summary>RegularExpression Id. </summary>
		public const int RANGEEX_GOOP = 33;
		/// <summary>Lexical state. </summary>
		public const int Boost = 0;
		/// <summary>Lexical state. </summary>
		public const int RangeEx = 1;
		/// <summary>Lexical state. </summary>
		public const int RangeIn = 2;
		/// <summary>Lexical state. </summary>
		public const int DEFAULT = 3;
		/// <summary>Literal token values. </summary>
		public static System.String[] tokenImage = new System.String[] {
            "<EOF>", 
            "<_NUM_CHAR>", 
            "<_ESCAPED_CHAR>", 
            "<_TERM_START_CHAR>", 
            "<_TERM_CHAR>", 
            "<_WHITESPACE>", 
            "<_QUOTED_CHAR>", 
            "<token of kind 7>", 
            "<AND>", 
            "<OR>", 
            "<NOT>", 
            "\"+\"", 
            "\"-\"", 
            "\"(\"", 
            "\")\"", 
            "\":\"", 
            "\"*\"", 
            "\"^\"", 
            "<QUOTED>", 
            "<TERM>", 
            "<FUZZY_SLOP>", 
            "<PREFIXTERM>", 
            "<WILDTERM>", 
            "\"[\"", 
            "\"{\"", 
            "<NUMBER>", 
            "\"TO\"", 
            "\"]\"", 
            "<RANGEIN_QUOTED>", 
            "<RANGEIN_GOOP>", 
            "\"TO\"", 
            "\"}\"", 
            "<RANGEEX_QUOTED>", 
            "<RANGEEX_GOOP>"
        };
	}
}
