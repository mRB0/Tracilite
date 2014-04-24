// tracilite-native.h

#pragma once

#include "bass.h"

using namespace System;
using namespace System::Diagnostics;

namespace TraciliteBridge {

	public ref class BridgeClass
	{
	public:
		String ^GetSomething() {
			Debug::WriteLine("Here I am!");

			BASS_DEVICEINFO deviceInfo;

			for (int i = 0; BASS_GetDeviceInfo(i, &deviceInfo); i++) {
				Debug::WriteLine(String::Format("Device info: {0}", gcnew String(deviceInfo.name)));
			}

			return "Hahaha!";
		}
	};
}
