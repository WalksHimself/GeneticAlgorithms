using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
namespace GA.Library
{
	public interface ISelector
	{
		void SetCandidates(Population candidates);
		List<IOrganism> PickCandidates(int count);
	}
}
