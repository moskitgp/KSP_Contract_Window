﻿#region license
/*The MIT License (MIT)
Contract Assembly - Monobehaviour To Check For Other Addons And Their Methods

Copyright (c) 2014 DMagic

KSP Plugin Framework by TriggerAu, 2014: http://forum.kerbalspaceprogram.com/threads/66503-KSP-Plugin-Framework

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using UnityEngine;

namespace ContractsWindow.Unity.Interfaces
{
	public interface IProgressPanel
	{
		bool IsVisible { get; set; }

		bool AnyInterval { get; }

		bool AnyPOI { get; }

		bool AnyStandard { get; }

		bool AnyBody { get; }

		bool AnyBodyNode(string s);

		IList<IIntervalNode> GetIntervalNodes { get; }

		IList<IStandardNode> GetPOINodes { get; }

		IList<IStandardNode> GetStandardNodes { get; }

		Dictionary<string, List<IStandardNode>> GetBodies { get; }

		void ProcessStyles(GameObject obj);
	}
}
