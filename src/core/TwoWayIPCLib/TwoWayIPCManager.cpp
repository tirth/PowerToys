// TwoWayIPCManager.cpp : Implementation of CTwoWayIPCManager

#include "pch.h"
#include "TwoWayIPCManager.h"
#include <iostream>
#include <string>

// CTwoWayIPCManager

using namespace std;


CTwoWayIPCManager::CTwoWayIPCManager()
{
    wcout << L"Default Constructor Invoked" << L"\n";
    m_MessagePipe = nullptr;
}


CTwoWayIPCManager::~CTwoWayIPCManager()
{
    delete this->m_MessagePipe;
}

/*
Send IPC Message.
*/
STDMETHODIMP CTwoWayIPCManager::SendMessage(BSTR message)
{
    wstring strMessage = (PCWSTR)message;
    wcout << strMessage.c_str() << L"\n";
    return S_OK;
}

/*
Start IPC.
*/
STDMETHODIMP CTwoWayIPCManager::StartIPC()
{
    wcout << L"Starting an IPC Process." << L"\n";
    return S_OK;
}

/*
 Initiliaze IPC object.

STDMETHODIMP CTwoWayIPCManager::InitializeIPC(callback_function func)
{
    std::wstring powertoys_pipe_name(L"\\\\.\\pipe\\powertoys_runner_");
    std::wstring settings_pipe_name(L"\\\\.\\pipe\\powertoys_settings_");
    wcout << powertoys_pipe_name.c_str() << L"\n";
    wcout << settings_pipe_name.c_str() << L"\n";

    wcout << L"Initialize Method Invoked" << L"\n";
    return S_OK;
}
*/