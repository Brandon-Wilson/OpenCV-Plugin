// Some copyright should be here...

#pragma once

#include "Modules/ModuleManager.h"



class FOpenCVModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};