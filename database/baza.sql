CREATE TABLE public.rezultat
(
    id integer NOT NULL DEFAULT nextval('rezultat_id_seq'::regclass),
    korisnik integer,
    datum timestamp without time zone DEFAULT now(),
    bodovi integer,
    CONSTRAINT rezultat_pkey PRIMARY KEY (id),
    CONSTRAINT rezultat_korisnik_fkey FOREIGN KEY (korisnik)
        REFERENCES public.korisnici (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.rezultat
    OWNER to postgres;

CREATE TABLE public.pitanja
(
    id integer NOT NULL DEFAULT nextval('pitanja_id_seq'::regclass),
    naziv character varying(200) COLLATE pg_catalog."default",
    odgovor odgovor[],
    CONSTRAINT pitanja_pkey PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public.pitanja
    OWNER to postgres;


CREATE TABLE public.korisnici
(
    id integer NOT NULL DEFAULT nextval('korisnici_id_seq'::regclass),
    ime character varying(25) COLLATE pg_catalog."default",
    prezime character varying(30) COLLATE pg_catalog."default",
    email character varying(30) COLLATE pg_catalog."default",
    korime character varying(15) COLLATE pg_catalog."default",
    lozinka character varying(15) COLLATE pg_catalog."default",
    slika oid,
    CONSTRAINT korisnici_pkey PRIMARY KEY (id)
)
WITH (
    OIDS = TRUE
)
TABLESPACE pg_default;

ALTER TABLE public.korisnici
    OWNER to postgres;

CREATE TYPE public.odgovor AS
(
	odgovor character varying(40),
	tocan boolean
);

ALTER TYPE public.odgovor
    OWNER TO postgres;
