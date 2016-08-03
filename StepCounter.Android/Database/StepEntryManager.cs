/*
 * My StepCounter:
 * Copyright (C) 2014 Refractored LLC | http://refractored.com
 * James Montemagno | http://twitter.com/JamesMontemagno | http://MotzCod.es
 * 
 * Michael James | http://twitter.com/micjames6 | http://micjames.co.uk/
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;

namespace StepCounter.Database {
	/// <summary>
	/// Manager classes are an abstraction on the data access layers
	/// </summary>
	public static class StepEntryManager {

		static StepEntryManager ()
		{
		}
		
		public static StepEntry GetStepEntry(DateTime time)
		{
			return StepEntryRepositoryADO.GetStepEntry(time);
		}
		
		public static IList<StepEntry> GetStepEntries ()
		{
			return new List<StepEntry>(StepEntryRepositoryADO.GetStepEntries());
		}
		
		public static int SaveStepEntry(StepEntry item)
		{
			return StepEntryRepositoryADO.SaveStepEntry(item);
		}
		
		public static int DeleteStepEntry(int id)
		{
			return StepEntryRepositoryADO.DeleteStepEntry(id);
		}
	}
}