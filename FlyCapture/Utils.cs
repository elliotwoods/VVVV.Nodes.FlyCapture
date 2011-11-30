using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VVVV.Nodes.EmguCV;
using FlyCapture2Managed;

namespace VVVV.Nodes.FlyCapture
{
	class Utils
	{
		static public TColourFormat GetFormat(PixelFormat format)
		{
			switch(format)
			{
				case PixelFormat.PixelFormatBgr:
				case PixelFormat.PixelFormatRgb8:
					return TColourFormat.RGB8;

				case PixelFormat.PixelFormatMono8:
				case PixelFormat.PixelFormatRaw8:
					return TColourFormat.L8;

				case PixelFormat.PixelFormatMono16:
				case PixelFormat.PixelFormatRaw16:
					return TColourFormat.L16;
			}
			throw (new Exception("Unsupported PixelFormat"));
		}
	}
}
