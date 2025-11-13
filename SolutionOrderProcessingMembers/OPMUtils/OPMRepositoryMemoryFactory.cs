
using OPMBL.Interfaces;
using OPMDL;

namespace OPMUtils
{
    public static class OPMRepositoryMemoryFactory
    {
        public static IOPMRepositoryMemory GetOPMRepositoryMemory()
        {
            return new OPMRepositoryMemory();
        }
    }
}
