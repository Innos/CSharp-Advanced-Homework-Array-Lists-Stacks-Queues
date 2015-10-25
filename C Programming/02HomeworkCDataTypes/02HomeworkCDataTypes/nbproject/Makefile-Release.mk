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
	${OBJECTDIR}/01DeclareVariables.o \
	${OBJECTDIR}/02FloatOrDouble.o \
	${OBJECTDIR}/03VariableInHexadecimalFormat.o \
	${OBJECTDIR}/04Gender.o \
	${OBJECTDIR}/05Names.o \
	${OBJECTDIR}/06QuotesInStrings.o \
	${OBJECTDIR}/07ExchangeVariableValues.o \
	${OBJECTDIR}/08EmployeeData.o \
	${OBJECTDIR}/09BankAccountData.o \
	${OBJECTDIR}/10ComparingFloats.o \
	${OBJECTDIR}/11PrintTheASCIITable.o


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
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/02homeworkcdatatypes

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/02homeworkcdatatypes: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.c} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/02homeworkcdatatypes ${OBJECTFILES} ${LDLIBSOPTIONS}

${OBJECTDIR}/01DeclareVariables.o: 01DeclareVariables.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/01DeclareVariables.o 01DeclareVariables.c

${OBJECTDIR}/02FloatOrDouble.o: 02FloatOrDouble.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/02FloatOrDouble.o 02FloatOrDouble.c

${OBJECTDIR}/03VariableInHexadecimalFormat.o: 03VariableInHexadecimalFormat.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/03VariableInHexadecimalFormat.o 03VariableInHexadecimalFormat.c

${OBJECTDIR}/04Gender.o: 04Gender.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/04Gender.o 04Gender.c

${OBJECTDIR}/05Names.o: 05Names.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/05Names.o 05Names.c

${OBJECTDIR}/06QuotesInStrings.o: 06QuotesInStrings.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/06QuotesInStrings.o 06QuotesInStrings.c

${OBJECTDIR}/07ExchangeVariableValues.o: 07ExchangeVariableValues.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/07ExchangeVariableValues.o 07ExchangeVariableValues.c

${OBJECTDIR}/08EmployeeData.o: 08EmployeeData.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/08EmployeeData.o 08EmployeeData.c

${OBJECTDIR}/09BankAccountData.o: 09BankAccountData.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/09BankAccountData.o 09BankAccountData.c

${OBJECTDIR}/10ComparingFloats.o: 10ComparingFloats.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/10ComparingFloats.o 10ComparingFloats.c

${OBJECTDIR}/11PrintTheASCIITable.o: 11PrintTheASCIITable.c 
	${MKDIR} -p ${OBJECTDIR}
	${RM} "$@.d"
	$(COMPILE.c) -O2 -MMD -MP -MF "$@.d" -o ${OBJECTDIR}/11PrintTheASCIITable.o 11PrintTheASCIITable.c

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/02homeworkcdatatypes

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
