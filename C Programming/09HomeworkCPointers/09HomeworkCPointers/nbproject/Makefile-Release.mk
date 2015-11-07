#
# Generated Makefile - do not edit!
#
# Edit the Makefile in the project folder instead (../Makefile). Each target
# has a -pre and a -post target defined where you can add customized code.
#
# This makefile implements configuration specific macros and targets.


# Environment
MKDIR=mkdir
CP=cp
GREP=grep
NM=nm
CCADMIN=CCadmin
RANLIB=ranlib
CC=gcc
CCC=g++
CXX=g++
FC=gfortran
AS=as

# Macros
CND_PLATFORM=GNU-Linux-x86
CND_DLIB_EXT=so
CND_CONF=Release
CND_DISTDIR=dist
CND_BUILDDIR=build

# Include project Makefile
include Makefile

# Object Directory
OBJECTDIR=${CND_BUILDDIR}/${CND_CONF}/${CND_PLATFORM}

# Object Files
OBJECTFILES= \
	${OBJECTDIR}/01SwapNumbers.o \
	${OBJECTDIR}/02ArrayPrint.o \
	${OBJECTDIR}/03PrintArrayReversed.o \
	${OBJECTDIR}/04PrintIntegerAdress.o \
	${OBJECTDIR}/05CreateNewInteger.o \
	${OBJECTDIR}/06DigitHate.o \
	${OBJECTDIR}/07GenericMemoryDump.o \
	${OBJECTDIR}/08GenericSwapFunction.o \
	${OBJECTDIR}/09Clients.o \
	${OBJECTDIR}/10LineReadingFunction.o


# C Compiler Flags
CFLAGS=

# CC Compiler Flags
CCFLAGS=
CXXFLAGS=

# Fortran Compiler Flags
FFLAGS=

# Assembler Flags
ASFLAGS=

# Link Libraries and Options
LDLIBSOPTIONS=

# Build Targets
.build-conf: ${BUILD_SUBPROJECTS}
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/09homeworkcpointers

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/09homeworkcpointers: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/09homeworkcpointers ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01SwapNumbers.o: 01SwapNumbers.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01SwapNumbers.o 01SwapNumbers.c

${OBJECTDIR}/02ArrayPrint.o: 02ArrayPrint.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02ArrayPrint.o 02ArrayPrint.c

${OBJECTDIR}/03PrintArrayReversed.o: 03PrintArrayReversed.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03PrintArrayReversed.o 03PrintArrayReversed.c

${OBJECTDIR}/04PrintIntegerAdress.o: 04PrintIntegerAdress.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04PrintIntegerAdress.o 04PrintIntegerAdress.c

${OBJECTDIR}/05CreateNewInteger.o: 05CreateNewInteger.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05CreateNewInteger.o 05CreateNewInteger.c

${OBJECTDIR}/06DigitHate.o: 06DigitHate.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06DigitHate.o 06DigitHate.c

${OBJECTDIR}/07GenericMemoryDump.o: 07GenericMemoryDump.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07GenericMemoryDump.o 07GenericMemoryDump.c

${OBJECTDIR}/08GenericSwapFunction.o: 08GenericSwapFunction.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08GenericSwapFunction.o 08GenericSwapFunction.c

${OBJECTDIR}/09Clients.o: 09Clients.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/09Clients.o 09Clients.c

${OBJECTDIR}/10LineReadingFunction.o: 10LineReadingFunction.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/10LineReadingFunction.o 10LineReadingFunction.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/09homeworkcpointers

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
