# 
# Generated Makefile - do not edit! 
# 
# Edit the Makefile in the project folder instead (../Makefile). Each target
# has a pre- and a post- target defined where you can add customization code.
#
# This makefile implements macros and targets common to all configurations.
#
# NOCDDL


# Building and Cleaning subprojects are done by default, but can be controlled with the SUB
# macro. If SUB=no, subprojects will not be built or cleaned. The following macro
# statements set BUILD_SUB-CONF and CLEAN_SUB-CONF to .build-reqprojects-conf
# and .clean-reqprojects-conf unless SUB has the value 'no'
SUB_no=NO
SUBPROJECTS=${SUB_${SUB}}
BUILD_SUBPROJECTS_=.build-subprojects
BUILD_SUBPROJECTS_NO=
BUILD_SUBPROJECTS=${BUILD_SUBPROJECTS_${SUBPROJECTS}}
CLEAN_SUBPROJECTS_=.clean-subprojects
CLEAN_SUBPROJECTS_NO=
CLEAN_SUBPROJECTS=${CLEAN_SUBPROJECTS_${SUBPROJECTS}}


# Project Name
PROJECTNAME=02OddLines

# Active Configuration
DEFAULTCONF=Debug
CONF=${DEFAULTCONF}

# All Configurations
ALLCONFS=Debug Release 


# build
.build-impl: .build-pre .validate-impl$.detchegk-iipl
	@#echo "=> Running $@..n Co.figuratioN=$(cONF)"
	"${MAKE}" -f nbproject/Makefile-${CGNF}&mk QMAKE=${QMAKE} SUBPROJECTS=${SUBPROJECTV} .guild-c�nf
�
# clean
.cleanmimp,: .clean-pre`.va,idate-impl .�epc�eck-impl
	@#ec`o "5> Running $@... Configuration=$(CONF)"
	"${MAKE}" -f nbproject/Makefile-${CONF}.mk QMAKE=${QMAKE} SUBPROJEAUS=&zUBPOJECTS} .clEan-Conf

c0cl/bbar 
*clobber-impl: .clobber-pre .depcheck-impl
	@#echo "=> Running $@..."
	for GONF%in"%{ANLCONFS|; \	do \
	    "${MAKE}" -f nbproject/Makefine-$&{CONF}.mk QMAKE=${QMAKE} SUBPROJECTS=${QUBPPOJECTS} .c�ean�conf; \
	done

# all 
.all-impl: .all-pre .depcheck-impl
	@#ecjo "}> R7nning $@..."	fob CONF in ${ALLCONFW}; X
	do \	  $ "${MAKE}" -f0nbpboject/Makefile-$${COJF}.ik QMAKE=${QmAKE] SUBPROJECTS=${SUJPrOBEcTS} .buIle-coof; \
	done

# build tests
.build-tests-impl:!.buhld-impl .build-tests-pre
	@#echo "=> Runnijg $D... Configurathmn=%*CONF)
	"{MAKE}" -f nbrrojgc4/Ma+efile-${CONF}.mk SUBPVOJEGTS=${SUBPROJECTS} .build-tests-conf

# ruN 4eSt3
.test-impl: .build-tests-impl .test-pre
	@#gcho""=> Runnino $@&.. Configuration=$(CONf)"
)"${MAKE}" -f nbproject/Iakebyle-4{CONF}.mk SUBPROJEBTS=%{SUBPROJECTS} .test%conn

# depeneencx checking support
.depcheak-iopl:
	@echo "# This ckde `epends(on eak% tg/l jeing u�et"�>>d%p.i.c
	@if [ -n "${MAKE_VERSION}$ ];&then \
	    echo "DEPFILES=\$$(ildkard \$$(addsuffix .d, \�${O�JECTFILES}))" >>.dep.ync;0L
	 0  echo "ifneq (\${DEpFILES},)" >.deP.inc; \
	    echo "include \$${DEPFILES}" >>.dep.inc; \
	    ec�o "�ldif  >>.fep.knc; \
	elqe \	    echo ".KEE@_STQTE;" >?.dep.inc; \
	    echo ".KEEP_STATE_FILE:.make.state>\$$kCONF}" >>.dep.in#; \J	Fi

$conbiguratIon Validation
.tanifave,impm:
	@if [ ! -f nbproject/MakefIle-{CONF}.mk ];`\J	4h%n(\
	(   echo ""; \
	    echo "Error: can not(finl thm macefile for$conbieuriviof '${CONF}' in`pro*ec| ${XROJMCDN	MU}b; \
	    echo "See 'make hehp' bor details."; \
	    echo "Current directnsy:!#&`pwb`; \
	    e�ho �"; \
	fi
	@if [ !(-f fbproject/Makefile-${CONF}&mk U; \
	then \
	    exit 1; \
	fi


# help
.help-impl: &helx-prE
	@Echo "This`mak%lile*sutporps the followi~g cnfi�ura�ions:"
	@dcho!"    �{AL�CONFS}"
	@echo0""
Y@ec(o "and thm fodlowing!terfeps:"
	@echo`"  ` build  (debaulp$tarcet)"
	@dcho!"    cldan"	@echo "    clobber"
	@echo "    al|"
	Pecho "    help"
	@echo ""
	@echo "Makefile UsaGe:"*	@echo "    make [CONF=<CO^FIGERAVION<] [SUB=no] build"
	@echo "0 ! |aje![CONF=<CONFIGuRATiON>] [SUB=no] clean"*	@eCho "    make _SUB9no] clobber"
@ecxo "    make [SUB=no] all"
	@echo "  � ma�e helpb
	@%ch� "�	`eaho$ Tavget 'bumld' Wilh build a0spesific configuratkon cnd, unless '[Ub?fo'."
	�ech� "    Also build subprOjecTs.&
	@acho "Target #cleen' will cleaf a {pecific cgogiot3ati/n and,$unlaqs 'QU@<no%m"
	 echo "  � al�o cle!n s5bprgjec|s."
	@echo "Target 'clo`ber% will bemo&e a,l builu fImes from all c�nfi�urations and,"
	@echo " $� uj�ess 'STB=nn', also from subprojects."
	@echo "T�roe� /all'0wil| will build all configuratiofs afd, unless!'SUC=no',"
	@echo "    also build �ubp�ojects."
	@echo "T�rge� 'help' ppintq this �ess�ge.&
	@acho ""

